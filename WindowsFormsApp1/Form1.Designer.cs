namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_time_start = new System.Windows.Forms.Label();
            this.lbl_time_end = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt = new System.Windows.Forms.TextBox();
            this.Recent_list = new System.Windows.Forms.ListBox();
            this.Favorite_list = new System.Windows.Forms.ListBox();
            this.btn_favorite = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_preview
            // 
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_preview.Location = new System.Drawing.Point(14, 299);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_next.Location = new System.Drawing.Point(94, 299);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_play.Location = new System.Drawing.Point(175, 299);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_pause.Location = new System.Drawing.Point(256, 299);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_stop.Location = new System.Drawing.Point(338, 299);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_open
            // 
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_open.Location = new System.Drawing.Point(418, 299);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(204, 23);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(9, 268);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(610, 17);
            this.p_bar.TabIndex = 6;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.track_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.ForeColor = System.Drawing.SystemColors.WindowText;
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(212, 99);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(359, 145);
            this.track_list.TabIndex = 7;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_art
            // 
            this.pic_art.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pic_art.Image = ((System.Drawing.Image)(resources.GetObject("pic_art.Image")));
            this.pic_art.Location = new System.Drawing.Point(12, 99);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(194, 145);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 8;
            this.pic_art.TabStop = false;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(138, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(337, 75);
            this.player.TabIndex = 9;
            this.player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // track_volume
            // 
            this.track_volume.BackColor = System.Drawing.Color.LightSteelBlue;
            this.track_volume.Location = new System.Drawing.Point(577, 99);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track_volume.Size = new System.Drawing.Size(45, 145);
            this.track_volume.TabIndex = 10;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_volume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(565, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.ForeColor = System.Drawing.Color.Black;
            this.lbl_volume.Location = new System.Drawing.Point(567, 3);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(37, 13);
            this.lbl_volume.TabIndex = 12;
            this.lbl_volume.Text = "100%";
            // 
            // lbl_time_start
            // 
            this.lbl_time_start.AutoSize = true;
            this.lbl_time_start.Font = new System.Drawing.Font("Bullpen 3D", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_start.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_time_start.Location = new System.Drawing.Point(12, 28);
            this.lbl_time_start.Name = "lbl_time_start";
            this.lbl_time_start.Size = new System.Drawing.Size(120, 43);
            this.lbl_time_start.TabIndex = 13;
            this.lbl_time_start.Text = "00:00";
            this.lbl_time_start.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_time_end
            // 
            this.lbl_time_end.AutoSize = true;
            this.lbl_time_end.Font = new System.Drawing.Font("Bullpen 3D", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time_end.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_time_end.Location = new System.Drawing.Point(481, 28);
            this.lbl_time_end.Name = "lbl_time_end";
            this.lbl_time_end.Size = new System.Drawing.Size(120, 43);
            this.lbl_time_end.TabIndex = 14;
            this.lbl_time_end.Text = "00:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_volume);
            this.panel2.Location = new System.Drawing.Point(9, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 174);
            this.panel2.TabIndex = 15;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(14, 338);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(611, 20);
            this.txt.TabIndex = 16;
            // 
            // Recent_list
            // 
            this.Recent_list.FormattingEnabled = true;
            this.Recent_list.Location = new System.Drawing.Point(14, 389);
            this.Recent_list.Name = "Recent_list";
            this.Recent_list.Size = new System.Drawing.Size(611, 56);
            this.Recent_list.TabIndex = 17;
            this.Recent_list.SelectedIndexChanged += new System.EventHandler(this.Recent_list_SelectedIndexChanged);
            // 
            // Favorite_list
            // 
            this.Favorite_list.FormattingEnabled = true;
            this.Favorite_list.Location = new System.Drawing.Point(14, 498);
            this.Favorite_list.Name = "Favorite_list";
            this.Favorite_list.Size = new System.Drawing.Size(611, 56);
            this.Favorite_list.TabIndex = 18;
            this.Favorite_list.SelectedIndexChanged += new System.EventHandler(this.Favorite_list_SelectedIndexChanged);
            // 
            // btn_favorite
            // 
            this.btn_favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_favorite.Location = new System.Drawing.Point(14, 459);
            this.btn_favorite.Name = "btn_favorite";
            this.btn_favorite.Size = new System.Drawing.Size(120, 22);
            this.btn_favorite.TabIndex = 19;
            this.btn_favorite.Text = "Add to Favorite";
            this.btn_favorite.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(138, 458);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 22);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(264, 458);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 22);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(390, 459);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(120, 22);
            this.btn_load.TabIndex = 22;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Recent files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_favorite);
            this.Controls.Add(this.Favorite_list);
            this.Controls.Add(this.Recent_list);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lbl_time_end);
            this.Controls.Add(this.lbl_time_start);
            this.Controls.Add(this.track_volume);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_time_start;
        private System.Windows.Forms.Label lbl_time_end;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ListBox Recent_list;
        private System.Windows.Forms.ListBox Favorite_list;
        private System.Windows.Forms.Button btn_favorite;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label2;
    }
}

