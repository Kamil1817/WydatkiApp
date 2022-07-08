using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WydatkiApp.Models;

namespace WydatkiApp.Interface
{
    /// <summary>
    /// Interface odpowiadadający za UPDATE, DELETE, INSERT do bazy danych
    /// </summary>
    public interface IFunctions
    {
        void SignUser(User signUser);
        User LoginUser(User loginUser);
        bool isUserExits(User userModel);
        User GetUpdatedUser(User userModel);
        void AddData(WydatkiModel wydatki);
        void UpdateData(WydatkiModel wydatki);
        void RemoveData(WydatkiModel wydatki);
        void UpdateMoney(int money, int id);
        public IQueryable<WydatkiModel> GetAll();
    }
}
