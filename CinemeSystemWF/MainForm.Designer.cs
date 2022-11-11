namespace CinemaSystemWF
{
    partial class MainForm
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
            this.DGShows = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckTicket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGShows)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGShows
            // 
            this.DGShows.AllowUserToAddRows = false;
            this.DGShows.AllowUserToDeleteRows = false;
            this.DGShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGShows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Film,
            this.Start,
            this.End,
            this.TicketPrice,
            this.Room,
            this.CheckTicket});
            this.DGShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGShows.Location = new System.Drawing.Point(0, 0);
            this.DGShows.Name = "DGShows";
            this.DGShows.ReadOnly = true;
            this.DGShows.RowTemplate.Height = 25;
            this.DGShows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGShows.Size = new System.Drawing.Size(776, 402);
            this.DGShows.TabIndex = 4;
            this.DGShows.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGShows_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "#";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 39;
            // 
            // Film
            // 
            this.Film.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Film.HeaderText = "Film";
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            this.Film.Width = 55;
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 56;
            // 
            // End
            // 
            this.End.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.End.HeaderText = "End";
            this.End.Name = "End";
            this.End.ReadOnly = true;
            this.End.Width = 52;
            // 
            // TicketPrice
            // 
            this.TicketPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TicketPrice.HeaderText = "TicketPrice";
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.ReadOnly = true;
            this.TicketPrice.Width = 89;
            // 
            // Room
            // 
            this.Room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Room.HeaderText = "Room";
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 64;
            // 
            // CheckTicket
            // 
            this.CheckTicket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckTicket.HeaderText = "CheckTicket";
            this.CheckTicket.Name = "CheckTicket";
            this.CheckTicket.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGShows);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 402);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGShows)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGShows;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Film;
        private DataGridViewTextBoxColumn Start;
        private DataGridViewTextBoxColumn End;
        private DataGridViewTextBoxColumn TicketPrice;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewButtonColumn CheckTicket;
        private Panel panel1;
    }
}