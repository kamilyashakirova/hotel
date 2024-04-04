namespace hotel
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            _timer = new System.Windows.Forms.Timer(components);
            searchpanel = new Panel();
            timelabel = new Label();
            searchpic = new PictureBox();
            tboxsearch = new TextBox();
            statuspanel = new Panel();
            checkingoutbtn = new RadioButton();
            occupiedbtn = new RadioButton();
            freebtn = new RadioButton();
            reservedbtn = new RadioButton();
            label3 = new Label();
            guestpanel = new Panel();
            checkingoutlbl = new Label();
            stoppedbylbl = new Label();
            namelbl = new Label();
            txtnbr = new TextBox();
            nbrlabel = new Label();
            showguestbtn = new Button();
            statuslbl = new Label();
            txtbcheckingout = new TextBox();
            txtbstoppedby = new TextBox();
            txtbname = new TextBox();
            txtstatus = new TextBox();
            guestpic = new PictureBox();
            tablepanel = new Panel();
            gueststable = new DataGridView();
            timer = new System.Windows.Forms.Timer(components);
            searchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchpic).BeginInit();
            statuspanel.SuspendLayout();
            guestpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestpic).BeginInit();
            tablepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gueststable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // searchpanel
            // 
            searchpanel.BackColor = Color.LavenderBlush;
            searchpanel.BorderStyle = BorderStyle.FixedSingle;
            searchpanel.Controls.Add(timelabel);
            searchpanel.Controls.Add(searchpic);
            searchpanel.Controls.Add(tboxsearch);
            searchpanel.Dock = DockStyle.Top;
            searchpanel.Location = new Point(0, 0);
            searchpanel.Name = "searchpanel";
            searchpanel.Size = new Size(1097, 47);
            searchpanel.TabIndex = 0;
            // 
            // timelabel
            // 
            timelabel.AutoSize = true;
            timelabel.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            timelabel.Location = new Point(-1, 13);
            timelabel.Name = "timelabel";
            timelabel.Size = new Size(69, 24);
            timelabel.TabIndex = 3;
            timelabel.Text = "Время";
            timelabel.TextChanged += timer_Tick;
            // 
            // searchpic
            // 
            searchpic.BorderStyle = BorderStyle.FixedSingle;
            searchpic.Image = (Image)resources.GetObject("searchpic.Image");
            searchpic.Location = new Point(688, 10);
            searchpic.Name = "searchpic";
            searchpic.Size = new Size(71, 27);
            searchpic.SizeMode = PictureBoxSizeMode.Zoom;
            searchpic.TabIndex = 2;
            searchpic.TabStop = false;
            searchpic.Click += searchbtn_Click;
            // 
            // tboxsearch
            // 
            tboxsearch.BackColor = Color.LavenderBlush;
            tboxsearch.BorderStyle = BorderStyle.FixedSingle;
            tboxsearch.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tboxsearch.Location = new Point(228, 9);
            tboxsearch.Name = "tboxsearch";
            tboxsearch.Size = new Size(450, 28);
            tboxsearch.TabIndex = 0;
            tboxsearch.Text = "Введите номер комнаты";
            // 
            // statuspanel
            // 
            statuspanel.BackColor = Color.LavenderBlush;
            statuspanel.Controls.Add(checkingoutbtn);
            statuspanel.Controls.Add(occupiedbtn);
            statuspanel.Controls.Add(freebtn);
            statuspanel.Controls.Add(reservedbtn);
            statuspanel.Controls.Add(label3);
            statuspanel.Dock = DockStyle.Left;
            statuspanel.Location = new Point(0, 47);
            statuspanel.Name = "statuspanel";
            statuspanel.Size = new Size(229, 609);
            statuspanel.TabIndex = 5;
            // 
            // checkingoutbtn
            // 
            checkingoutbtn.AutoSize = true;
            checkingoutbtn.Font = new Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkingoutbtn.Location = new Point(10, 267);
            checkingoutbtn.Name = "checkingoutbtn";
            checkingoutbtn.Size = new Size(149, 29);
            checkingoutbtn.TabIndex = 8;
            checkingoutbtn.TabStop = true;
            checkingoutbtn.Text = "Выселяются";
            checkingoutbtn.UseVisualStyleBackColor = true;
            checkingoutbtn.CheckedChanged += checkingoutbtn_CheckedChanged;
            // 
            // occupiedbtn
            // 
            occupiedbtn.AutoSize = true;
            occupiedbtn.Font = new Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            occupiedbtn.Location = new Point(10, 232);
            occupiedbtn.Name = "occupiedbtn";
            occupiedbtn.Size = new Size(98, 29);
            occupiedbtn.TabIndex = 7;
            occupiedbtn.TabStop = true;
            occupiedbtn.Text = "Занято";
            occupiedbtn.UseVisualStyleBackColor = true;
            occupiedbtn.CheckedChanged += occupiedbtn_CheckedChanged;
            // 
            // freebtn
            // 
            freebtn.AutoSize = true;
            freebtn.Font = new Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            freebtn.Location = new Point(10, 200);
            freebtn.Name = "freebtn";
            freebtn.Size = new Size(126, 29);
            freebtn.TabIndex = 6;
            freebtn.TabStop = true;
            freebtn.Text = "Свободно";
            freebtn.UseVisualStyleBackColor = true;
            freebtn.CheckedChanged += freebtn_CheckedChanged;
            // 
            // reservedbtn
            // 
            reservedbtn.AutoSize = true;
            reservedbtn.Font = new Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            reservedbtn.Location = new Point(10, 165);
            reservedbtn.Name = "reservedbtn";
            reservedbtn.Size = new Size(202, 29);
            reservedbtn.TabIndex = 5;
            reservedbtn.TabStop = true;
            reservedbtn.Text = "Зарезервировано";
            reservedbtn.UseVisualStyleBackColor = true;
            reservedbtn.CheckedChanged += reservedbtn_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(53, 101);
            label3.Name = "label3";
            label3.Size = new Size(113, 39);
            label3.TabIndex = 4;
            label3.Text = "Статус";
            // 
            // guestpanel
            // 
            guestpanel.BackColor = Color.LavenderBlush;
            guestpanel.Controls.Add(checkingoutlbl);
            guestpanel.Controls.Add(stoppedbylbl);
            guestpanel.Controls.Add(namelbl);
            guestpanel.Controls.Add(txtnbr);
            guestpanel.Controls.Add(nbrlabel);
            guestpanel.Controls.Add(showguestbtn);
            guestpanel.Controls.Add(statuslbl);
            guestpanel.Controls.Add(txtbcheckingout);
            guestpanel.Controls.Add(txtbstoppedby);
            guestpanel.Controls.Add(txtbname);
            guestpanel.Controls.Add(txtstatus);
            guestpanel.Controls.Add(guestpic);
            guestpanel.Dock = DockStyle.Right;
            guestpanel.Location = new Point(760, 47);
            guestpanel.Name = "guestpanel";
            guestpanel.Size = new Size(337, 609);
            guestpanel.TabIndex = 4;
            // 
            // checkingoutlbl
            // 
            checkingoutlbl.AutoSize = true;
            checkingoutlbl.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkingoutlbl.Location = new Point(15, 440);
            checkingoutlbl.Name = "checkingoutlbl";
            checkingoutlbl.Size = new Size(200, 24);
            checkingoutlbl.TabIndex = 11;
            checkingoutlbl.Text = "Дата выезда из отеля";
            // 
            // stoppedbylbl
            // 
            stoppedbylbl.AutoSize = true;
            stoppedbylbl.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stoppedbylbl.Location = new Point(15, 382);
            stoppedbylbl.Name = "stoppedbylbl";
            stoppedbylbl.Size = new Size(185, 24);
            stoppedbylbl.TabIndex = 10;
            stoppedbylbl.Text = "Дата заезда в отель";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            namelbl.Location = new Point(15, 324);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(54, 24);
            namelbl.TabIndex = 9;
            namelbl.Text = "ФИО";
            // 
            // txtnbr
            // 
            txtnbr.BackColor = Color.LavenderBlush;
            txtnbr.BorderStyle = BorderStyle.FixedSingle;
            txtnbr.Font = new Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtnbr.Location = new Point(123, 19);
            txtnbr.Name = "txtnbr";
            txtnbr.Size = new Size(88, 29);
            txtnbr.TabIndex = 8;
            // 
            // nbrlabel
            // 
            nbrlabel.AutoSize = true;
            nbrlabel.Font = new Font("Montserrat", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nbrlabel.Location = new Point(15, 23);
            nbrlabel.Name = "nbrlabel";
            nbrlabel.Size = new Size(102, 25);
            nbrlabel.TabIndex = 7;
            nbrlabel.Text = "Номер №";
            // 
            // showguestbtn
            // 
            showguestbtn.BackColor = Color.White;
            showguestbtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showguestbtn.Location = new Point(70, 525);
            showguestbtn.Name = "showguestbtn";
            showguestbtn.Size = new Size(196, 48);
            showguestbtn.TabIndex = 6;
            showguestbtn.Text = "Просмотр карточки";
            showguestbtn.UseVisualStyleBackColor = false;
            showguestbtn.Click += showguestcardbtn_Click;
            // 
            // statuslbl
            // 
            statuslbl.AutoSize = true;
            statuslbl.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            statuslbl.Location = new Point(15, 266);
            statuslbl.Name = "statuslbl";
            statuslbl.Size = new Size(67, 24);
            statuslbl.TabIndex = 5;
            statuslbl.Text = "Статус";
            // 
            // txtbcheckingout
            // 
            txtbcheckingout.BorderStyle = BorderStyle.FixedSingle;
            txtbcheckingout.Font = new Font("Montserrat", 10.2F);
            txtbcheckingout.Location = new Point(15, 467);
            txtbcheckingout.Name = "txtbcheckingout";
            txtbcheckingout.Size = new Size(305, 28);
            txtbcheckingout.TabIndex = 4;
            // 
            // txtbstoppedby
            // 
            txtbstoppedby.BorderStyle = BorderStyle.FixedSingle;
            txtbstoppedby.Font = new Font("Montserrat", 10.2F);
            txtbstoppedby.Location = new Point(15, 409);
            txtbstoppedby.Name = "txtbstoppedby";
            txtbstoppedby.Size = new Size(305, 28);
            txtbstoppedby.TabIndex = 3;
            // 
            // txtbname
            // 
            txtbname.BorderStyle = BorderStyle.FixedSingle;
            txtbname.Font = new Font("Montserrat", 10.2F);
            txtbname.Location = new Point(15, 351);
            txtbname.Name = "txtbname";
            txtbname.Size = new Size(305, 28);
            txtbname.TabIndex = 2;
            // 
            // txtstatus
            // 
            txtstatus.BorderStyle = BorderStyle.FixedSingle;
            txtstatus.Font = new Font("Montserrat", 10.2F);
            txtstatus.Location = new Point(15, 293);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(305, 28);
            txtstatus.TabIndex = 1;
            // 
            // guestpic
            // 
            guestpic.BorderStyle = BorderStyle.FixedSingle;
            guestpic.Location = new Point(70, 69);
            guestpic.Name = "guestpic";
            guestpic.Size = new Size(196, 192);
            guestpic.SizeMode = PictureBoxSizeMode.Zoom;
            guestpic.TabIndex = 0;
            guestpic.TabStop = false;
            // 
            // tablepanel
            // 
            tablepanel.AutoScroll = true;
            tablepanel.AutoSize = true;
            tablepanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tablepanel.BackColor = Color.White;
            tablepanel.BorderStyle = BorderStyle.FixedSingle;
            tablepanel.Controls.Add(gueststable);
            tablepanel.Dock = DockStyle.Fill;
            tablepanel.Location = new Point(229, 47);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(531, 609);
            tablepanel.TabIndex = 6;
            // 
            // gueststable
            // 
            gueststable.AllowUserToAddRows = false;
            gueststable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gueststable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gueststable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gueststable.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gueststable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gueststable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gueststable.DefaultCellStyle = dataGridViewCellStyle3;
            gueststable.Location = new Point(1, 100);
            gueststable.Name = "gueststable";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gueststable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gueststable.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gueststable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gueststable.Size = new Size(527, 385);
            gueststable.TabIndex = 0;
            gueststable.DoubleClick += gueststable_DoubleClick;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1097, 656);
            Controls.Add(tablepanel);
            Controls.Add(statuspanel);
            Controls.Add(label1);
            Controls.Add(guestpanel);
            Controls.Add(searchpanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "\"only stars\"";
            Load += MainForm_Load;
            searchpanel.ResumeLayout(false);
            searchpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchpic).EndInit();
            statuspanel.ResumeLayout(false);
            statuspanel.PerformLayout();
            guestpanel.ResumeLayout(false);
            guestpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestpic).EndInit();
            tablepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gueststable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer _timer;
        private Panel searchpanel;
        private PictureBox searchpic;
        private Panel statuspanel;
        private Label label3;
        private Panel tablepanel;
        private System.Windows.Forms.Timer timer;
        private Label statuslbl;
        private Label nbrlabel;
        private Label namelbl;
        private Label checkingoutlbl;
        private Label stoppedbylbl;
        public Label timelabel;
        public TextBox tboxsearch;
        public DataGridView gueststable;
        public RadioButton reservedbtn;
        public RadioButton freebtn;
        public RadioButton checkingoutbtn;
        public RadioButton occupiedbtn;
        public Panel guestpanel;
        public PictureBox guestpic;
        public TextBox txtbcheckingout;
        public TextBox txtbstoppedby;
        public TextBox txtbname;
        public TextBox txtstatus;
        public TextBox txtnbr;
        public Button showguestbtn;
    }
}
