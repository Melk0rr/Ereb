namespace Ereb
{
    partial class Form1
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
            this.new_game_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.main_title = new System.Windows.Forms.Label();
            this.factionPanel = new System.Windows.Forms.Panel();
            this.faction_to_menu_button = new System.Windows.Forms.Button();
            this.faction_title = new System.Windows.Forms.Label();
            this.faction_choose = new System.Windows.Forms.Label();
            this.factionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_game_button
            // 
            this.new_game_button.BackColor = System.Drawing.Color.Transparent;
            this.new_game_button.BackgroundImage = global::Ereb.Properties.Resources.bg;
            this.new_game_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.new_game_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_game_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.new_game_button.FlatAppearance.BorderSize = 2;
            this.new_game_button.Font = new System.Drawing.Font("David CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.new_game_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.new_game_button.Location = new System.Drawing.Point(602, 305);
            this.new_game_button.Margin = new System.Windows.Forms.Padding(4);
            this.new_game_button.Name = "new_game_button";
            this.new_game_button.Size = new System.Drawing.Size(337, 63);
            this.new_game_button.TabIndex = 0;
            this.new_game_button.Text = "New Game";
            this.new_game_button.UseVisualStyleBackColor = false;
            this.new_game_button.Click += new System.EventHandler(this.new_game_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.Transparent;
            this.settings_button.BackgroundImage = global::Ereb.Properties.Resources.bg;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings_button.FlatAppearance.BorderSize = 2;
            this.settings_button.Font = new System.Drawing.Font("David CLM", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.settings_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settings_button.Location = new System.Drawing.Point(602, 375);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(337, 63);
            this.settings_button.TabIndex = 1;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // main_title
            // 
            this.main_title.AutoSize = true;
            this.main_title.BackColor = System.Drawing.Color.Transparent;
            this.main_title.Font = new System.Drawing.Font("David CLM", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.main_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.main_title.Location = new System.Drawing.Point(664, 190);
            this.main_title.Name = "main_title";
            this.main_title.Size = new System.Drawing.Size(213, 101);
            this.main_title.TabIndex = 2;
            this.main_title.Text = "Ereb";
            // 
            // factionPanel
            // 
            this.factionPanel.BackColor = System.Drawing.Color.Transparent;
            this.factionPanel.Controls.Add(this.faction_choose);
            this.factionPanel.Controls.Add(this.faction_to_menu_button);
            this.factionPanel.Controls.Add(this.faction_title);
            this.factionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factionPanel.Location = new System.Drawing.Point(0, 0);
            this.factionPanel.Name = "factionPanel";
            this.factionPanel.Size = new System.Drawing.Size(1540, 845);
            this.factionPanel.TabIndex = 3;
            this.factionPanel.Visible = false;
            // 
            // faction_to_menu_button
            // 
            this.faction_to_menu_button.BackgroundImage = global::Ereb.Properties.Resources.bg;
            this.faction_to_menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.faction_to_menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faction_to_menu_button.Font = new System.Drawing.Font("David CLM", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.faction_to_menu_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.faction_to_menu_button.Location = new System.Drawing.Point(66, 772);
            this.faction_to_menu_button.Name = "faction_to_menu_button";
            this.faction_to_menu_button.Size = new System.Drawing.Size(237, 50);
            this.faction_to_menu_button.TabIndex = 1;
            this.faction_to_menu_button.Text = "< Return to main menu";
            this.faction_to_menu_button.UseVisualStyleBackColor = true;
            this.faction_to_menu_button.Click += new System.EventHandler(this.faction_to_menu_button_Click);
            // 
            // faction_title
            // 
            this.faction_title.AutoSize = true;
            this.faction_title.Font = new System.Drawing.Font("David CLM", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.faction_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.faction_title.Location = new System.Drawing.Point(664, 14);
            this.faction_title.Name = "faction_title";
            this.faction_title.Size = new System.Drawing.Size(213, 101);
            this.faction_title.TabIndex = 0;
            this.faction_title.Text = "Ereb";
            // 
            // faction_choose
            // 
            this.faction_choose.AutoSize = true;
            this.faction_choose.Font = new System.Drawing.Font("David CLM", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.faction_choose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.faction_choose.Location = new System.Drawing.Point(12, 147);
            this.faction_choose.Name = "faction_choose";
            this.faction_choose.Size = new System.Drawing.Size(304, 37);
            this.faction_choose.TabIndex = 2;
            this.faction_choose.Text = "Choose your faction:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ereb.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.factionPanel);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.main_title);
            this.Controls.Add(this.new_game_button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("David CLM", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ereb";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.factionPanel.ResumeLayout(false);
            this.factionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_game_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Label main_title;
        private System.Windows.Forms.Panel factionPanel;
        private System.Windows.Forms.Label faction_title;
        private System.Windows.Forms.Button faction_to_menu_button;
        private System.Windows.Forms.Label faction_choose;
    }
}

