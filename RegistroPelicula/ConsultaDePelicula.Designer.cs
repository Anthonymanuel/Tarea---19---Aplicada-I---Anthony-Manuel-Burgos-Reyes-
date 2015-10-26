namespace RegistroPelicula
{
    partial class ConsultaDePelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDePelicula));
            this.PeliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.MostrarDataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConsultaComboBox = new System.Windows.Forms.ComboBox();
            this.FotoPictureBox = new System.Windows.Forms.PictureBox();
            this.PeliculaGroupBox = new System.Windows.Forms.GroupBox();
            this.ReproductorAxWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).BeginInit();
            this.PeliculaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorAxWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PeliculaIdTextBox
            // 
            this.PeliculaIdTextBox.Location = new System.Drawing.Point(167, 61);
            this.PeliculaIdTextBox.Name = "PeliculaIdTextBox";
            this.PeliculaIdTextBox.Size = new System.Drawing.Size(119, 20);
            this.PeliculaIdTextBox.TabIndex = 1;
            // 
            // MostrarDataGridView
            // 
            this.MostrarDataGridView.AllowUserToAddRows = false;
            this.MostrarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MostrarDataGridView.Location = new System.Drawing.Point(12, 138);
            this.MostrarDataGridView.Name = "MostrarDataGridView";
            this.MostrarDataGridView.ReadOnly = true;
            this.MostrarDataGridView.Size = new System.Drawing.Size(806, 111);
            this.MostrarDataGridView.TabIndex = 2;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::RegistroPelicula.Properties.Resources._1443950301_adsense_for_search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(292, 48);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 47);
            this.BuscarButton.TabIndex = 3;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click_1);
            // 
            // ConsultaComboBox
            // 
            this.ConsultaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultaComboBox.FormattingEnabled = true;
            this.ConsultaComboBox.Items.AddRange(new object[] {
            "PeliculaId",
            "Titulo",
            "Descripcion",
            "Ano",
            "Calificacion",
            "IMDB",
            "CategoriaId"});
            this.ConsultaComboBox.Location = new System.Drawing.Point(40, 61);
            this.ConsultaComboBox.Name = "ConsultaComboBox";
            this.ConsultaComboBox.Size = new System.Drawing.Size(121, 21);
            this.ConsultaComboBox.TabIndex = 2;
            // 
            // FotoPictureBox
            // 
            this.FotoPictureBox.Location = new System.Drawing.Point(40, 298);
            this.FotoPictureBox.Name = "FotoPictureBox";
            this.FotoPictureBox.Size = new System.Drawing.Size(100, 111);
            this.FotoPictureBox.TabIndex = 4;
            this.FotoPictureBox.TabStop = false;
            // 
            // PeliculaGroupBox
            // 
            this.PeliculaGroupBox.Controls.Add(this.ReproductorAxWindowsMediaPlayer1);
            this.PeliculaGroupBox.Location = new System.Drawing.Point(187, 265);
            this.PeliculaGroupBox.Name = "PeliculaGroupBox";
            this.PeliculaGroupBox.Size = new System.Drawing.Size(637, 189);
            this.PeliculaGroupBox.TabIndex = 5;
            this.PeliculaGroupBox.TabStop = false;
            this.PeliculaGroupBox.Text = "Pelicula";
            // 
            // ReproductorAxWindowsMediaPlayer1
            // 
            this.ReproductorAxWindowsMediaPlayer1.Enabled = true;
            this.ReproductorAxWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 19);
            this.ReproductorAxWindowsMediaPlayer1.Name = "ReproductorAxWindowsMediaPlayer1";
            this.ReproductorAxWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ReproductorAxWindowsMediaPlayer1.OcxState")));
            this.ReproductorAxWindowsMediaPlayer1.Size = new System.Drawing.Size(625, 155);
            this.ReproductorAxWindowsMediaPlayer1.TabIndex = 17;
            // 
            // PauseButton
            // 
            this.PauseButton.Image = global::RegistroPelicula.Properties.Resources._1444677738_ic_pause_48px;
            this.PauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PauseButton.Location = new System.Drawing.Point(280, 461);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(64, 32);
            this.PauseButton.TabIndex = 18;
            this.PauseButton.Text = "Pause";
            this.PauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Image = global::RegistroPelicula.Properties.Resources._1444677751_24_Stop;
            this.StopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopButton.Location = new System.Drawing.Point(350, 461);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(60, 32);
            this.StopButton.TabIndex = 19;
            this.StopButton.Text = "Stop";
            this.StopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Image = global::RegistroPelicula.Properties.Resources._1444677721_ic_play_arrow_48px;
            this.PlayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayButton.Location = new System.Drawing.Point(218, 460);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(56, 33);
            this.PlayButton.TabIndex = 20;
            this.PlayButton.Text = "Play";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ConsultaDePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroPelicula.Properties.Resources.rollo_de_pelicula;
            this.ClientSize = new System.Drawing.Size(836, 494);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PeliculaGroupBox);
            this.Controls.Add(this.FotoPictureBox);
            this.Controls.Add(this.ConsultaComboBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.MostrarDataGridView);
            this.Controls.Add(this.PeliculaIdTextBox);
            this.Name = "ConsultaDePelicula";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.ConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MostrarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPictureBox)).EndInit();
            this.PeliculaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReproductorAxWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PeliculaIdTextBox;
        private System.Windows.Forms.DataGridView MostrarDataGridView;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox ConsultaComboBox;
        private System.Windows.Forms.PictureBox FotoPictureBox;
        private System.Windows.Forms.GroupBox PeliculaGroupBox;
        private AxWMPLib.AxWindowsMediaPlayer ReproductorAxWindowsMediaPlayer1;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PlayButton;
    }
}