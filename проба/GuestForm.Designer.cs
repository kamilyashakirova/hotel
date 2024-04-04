namespace hotel
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            guestcardlabel = new Label();
            txtboxname = new TextBox();
            txtboxbirthday = new TextBox();
            txtboxstoppedby = new TextBox();
            txtboxchekingout = new TextBox();
            txtboxwithAnimal = new TextBox();
            gnamelbl = new Label();
            gwithAnimallbl = new Label();
            gcheckingoutlbl = new Label();
            gstoppedbylbl = new Label();
            gBDlbl = new Label();
            SuspendLayout();
            // 
            // guestcardlabel
            // 
            guestcardlabel.AutoSize = true;
            guestcardlabel.BackColor = Color.LavenderBlush;
            guestcardlabel.Font = new Font("Montserrat", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            guestcardlabel.Location = new Point(120, 37);
            guestcardlabel.Name = "guestcardlabel";
            guestcardlabel.Size = new Size(233, 39);
            guestcardlabel.TabIndex = 0;
            guestcardlabel.Text = "Карточка гостя";
            // 
            // txtboxname
            // 
            txtboxname.Font = new Font("Montserrat", 10.2F);
            txtboxname.Location = new Point(12, 112);
            txtboxname.Name = "txtboxname";
            txtboxname.Size = new Size(466, 28);
            txtboxname.TabIndex = 1;
            // 
            // txtboxbirthday
            // 
            txtboxbirthday.Font = new Font("Montserrat", 10.2F);
            txtboxbirthday.Location = new Point(12, 171);
            txtboxbirthday.Name = "txtboxbirthday";
            txtboxbirthday.Size = new Size(466, 28);
            txtboxbirthday.TabIndex = 2;
            // 
            // txtboxstoppedby
            // 
            txtboxstoppedby.Font = new Font("Montserrat", 10.2F);
            txtboxstoppedby.Location = new Point(12, 233);
            txtboxstoppedby.Name = "txtboxstoppedby";
            txtboxstoppedby.Size = new Size(466, 28);
            txtboxstoppedby.TabIndex = 3;
            // 
            // txtboxchekingout
            // 
            txtboxchekingout.Font = new Font("Montserrat", 10.2F);
            txtboxchekingout.Location = new Point(12, 294);
            txtboxchekingout.Name = "txtboxchekingout";
            txtboxchekingout.Size = new Size(466, 28);
            txtboxchekingout.TabIndex = 4;
            // 
            // txtboxwithAnimal
            // 
            txtboxwithAnimal.Font = new Font("Montserrat", 10.2F);
            txtboxwithAnimal.Location = new Point(12, 356);
            txtboxwithAnimal.Name = "txtboxwithAnimal";
            txtboxwithAnimal.Size = new Size(466, 28);
            txtboxwithAnimal.TabIndex = 5;
            // 
            // gnamelbl
            // 
            gnamelbl.AutoSize = true;
            gnamelbl.Font = new Font("Montserrat", 10.2F);
            gnamelbl.Location = new Point(12, 85);
            gnamelbl.Name = "gnamelbl";
            gnamelbl.Size = new Size(54, 24);
            gnamelbl.TabIndex = 6;
            gnamelbl.Text = "ФИО";
            // 
            // gwithAnimallbl
            // 
            gwithAnimallbl.AutoSize = true;
            gwithAnimallbl.Font = new Font("Montserrat", 10.2F);
            gwithAnimallbl.Location = new Point(12, 329);
            gwithAnimallbl.Name = "gwithAnimallbl";
            gwithAnimallbl.Size = new Size(118, 24);
            gwithAnimallbl.TabIndex = 7;
            gwithAnimallbl.Text = "С животным";
            // 
            // gcheckingoutlbl
            // 
            gcheckingoutlbl.AutoSize = true;
            gcheckingoutlbl.Font = new Font("Montserrat", 10.2F);
            gcheckingoutlbl.Location = new Point(12, 267);
            gcheckingoutlbl.Name = "gcheckingoutlbl";
            gcheckingoutlbl.Size = new Size(204, 24);
            gcheckingoutlbl.TabIndex = 8;
            gcheckingoutlbl.Text = "День выезда из отеля";
            // 
            // gstoppedbylbl
            // 
            gstoppedbylbl.AutoSize = true;
            gstoppedbylbl.Font = new Font("Montserrat", 10.2F);
            gstoppedbylbl.Location = new Point(12, 206);
            gstoppedbylbl.Name = "gstoppedbylbl";
            gstoppedbylbl.Size = new Size(189, 24);
            gstoppedbylbl.TabIndex = 9;
            gstoppedbylbl.Text = "День заезда в отель";
            // 
            // gBDlbl
            // 
            gBDlbl.AutoSize = true;
            gBDlbl.Font = new Font("Montserrat", 10.2F);
            gBDlbl.Location = new Point(12, 144);
            gBDlbl.Name = "gBDlbl";
            gBDlbl.Size = new Size(152, 24);
            gBDlbl.TabIndex = 10;
            gBDlbl.Text = "День рождения";
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(490, 575);
            Controls.Add(gBDlbl);
            Controls.Add(gstoppedbylbl);
            Controls.Add(gcheckingoutlbl);
            Controls.Add(gwithAnimallbl);
            Controls.Add(gnamelbl);
            Controls.Add(txtboxwithAnimal);
            Controls.Add(txtboxchekingout);
            Controls.Add(txtboxstoppedby);
            Controls.Add(txtboxbirthday);
            Controls.Add(txtboxname);
            Controls.Add(guestcardlabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GuestForm";
            Text = "карточка гостя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label guestcardlabel;
        public TextBox txtboxname;
        public TextBox txtboxbirthday;
        public TextBox txtboxstoppedby;
        public TextBox txtboxchekingout;
        public TextBox txtboxwithAnimal;
        private Label gnamelbl;
        private Label gwithAnimallbl;
        private Label gcheckingoutlbl;
        private Label gstoppedbylbl;
        private Label gBDlbl;
    }
}