
namespace WydatkiApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(569, 510);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(288, 274);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(69, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Usuń";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.Maroon;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(469, 510);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(70, 31);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Zmień";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(421, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stan Twojego konta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMoney
            // 
            this.labelMoney.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelMoney.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoney.ForeColor = System.Drawing.Color.Firebrick;
            this.labelMoney.Location = new System.Drawing.Point(395, 185);
            this.labelMoney.Multiline = true;
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(305, 39);
            this.labelMoney.TabIndex = 5;
            this.labelMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Description,
            this.Amount});
            this.listView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(270, 617);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // Description
            // 
            this.Description.Text = "Opis";
            this.Description.Width = 150;
            // 
            // Amount
            // 
            this.Amount.Text = "Kwota";
            this.Amount.Width = 80;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(469, 424);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(170, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.Location = new System.Drawing.Point(469, 481);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(170, 22);
            this.txtAmount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(469, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Opis wydatku / przychodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(469, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kwota wydatku / przychodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Autor: Kamil Koncewicz | Nr albumu 63090";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 641);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie finansami osobistymi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labelMoney;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Id;
    }
}