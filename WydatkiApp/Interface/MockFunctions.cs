using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WydatkiApp.Models;

namespace WydatkiApp.Interface
{
    /// <summary>
    /// Funkcje do bazy danych 
    /// </summary>
    public class MockFunctions : IFunctions
    {
        private readonly DataBaseContext _context;
        public MockFunctions(DataBaseContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Zwraca całą liste z bazy danych
        /// </summary>
        public IQueryable<WydatkiModel> GetAll()
        {
            return _context.Wydatki;
        }
        /// <summary>
        /// Sprawdzanie czy istnieje konto z takim emailem
        /// </summary>
        public bool isUserExits(User userModel)
        {
            var findUser = _context.User.FirstOrDefault(x => x.Email == userModel.Email);

            if (findUser == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Logowanie
        /// </summary>
        User IFunctions.LoginUser(User loginUser)
        {
            var findLogUser = _context.User.FirstOrDefault(x => x.Email == loginUser.Email);

            if (findLogUser != null && findLogUser.Password == loginUser.Password)
            {
                return findLogUser;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Rejestracja uzytkownika
        /// </summary>
        /// <param name="signUser"></param>
        public void SignUser(User signUser)
        {
            _context.Add(signUser);

            _context.SaveChanges();
        }
        /// <summary>
        /// Usuwanie elementu z bazy danych
        /// </summary>
        /// <param name="wydatki"></param>
        public void RemoveData(WydatkiModel wydatki)
        {
            _context.Remove(wydatki);

            _context.SaveChanges();
        }
        /// <summary>
        /// Zmienianie elementu z bazy danych
        /// </summary>
        /// <param name="wydatki"></param>
        public void UpdateData(WydatkiModel wydatki)
        {
            var UpdateData =  _context.Wydatki.FirstOrDefault(x => x.Id == wydatki.Id);

            UpdateData.Amount = wydatki.Amount;
            UpdateData.Description = wydatki.Description;

            _context.SaveChanges();
        }
        /// <summary>
        /// Dodawanie elementu do bazy danych
        /// </summary>
        /// <param name="wydatki"></param>
        public void AddData(WydatkiModel wydatki)
        {
            _context.Add(wydatki);
            _context.SaveChanges();
        }
        /// <summary>
        /// Update obecnego stanu konta
        /// </summary>
        /// <param name="money"></param>
        /// <param name="id"></param>
        public void UpdateMoney(int money, int id)
        {
            var userMoney = _context.User.FirstOrDefault(x => x.Id == id);

            userMoney.Money = money;

            _context.SaveChanges();
        }
        /// <summary>
        /// Pobranie aktualnego użytkownika
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public User GetUpdatedUser(User userModel)
        {
            var updatedUser = _context.User.FirstOrDefault(x => x.Id == userModel.Id);

            return updatedUser;
        }
    }
}