namespace RoomBuilder
{
    partial class RoomBuilder
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
            this.chkSecret = new System.Windows.Forms.CheckedListBox();
            this.lblSecret = new System.Windows.Forms.Label();
            this.chkEnemies = new System.Windows.Forms.CheckedListBox();
            this.lblEnemies = new System.Windows.Forms.Label();
            this.chkItems = new System.Windows.Forms.CheckedListBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.chkConnections = new System.Windows.Forms.CheckedListBox();
            this.lblConnections = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnNewEnemy = new System.Windows.Forms.Button();
            this.lblNewItem = new System.Windows.Forms.Label();
            this.lblNewEnemy = new System.Windows.Forms.Label();
            this.lblRoomText = new System.Windows.Forms.Label();
            this.txtRoomText = new System.Windows.Forms.TextBox();
            this.btnMakeRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkSecret
            // 
            this.chkSecret.FormattingEnabled = true;
            this.chkSecret.Items.AddRange(new object[] {
            "Weak Wall",
            "Trap Door"});
            this.chkSecret.Location = new System.Drawing.Point(382, 54);
            this.chkSecret.Name = "chkSecret";
            this.chkSecret.Size = new System.Drawing.Size(120, 94);
            this.chkSecret.TabIndex = 19;
            // 
            // lblSecret
            // 
            this.lblSecret.AutoSize = true;
            this.lblSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecret.Location = new System.Drawing.Point(378, 31);
            this.lblSecret.Name = "lblSecret";
            this.lblSecret.Size = new System.Drawing.Size(56, 20);
            this.lblSecret.TabIndex = 18;
            this.lblSecret.Text = "Secret";
            // 
            // chkEnemies
            // 
            this.chkEnemies.FormattingEnabled = true;
            this.chkEnemies.Items.AddRange(new object[] {
            "Dragon",
            "Spider",
            "Goblin",
            "Zombie",
            "Sorceror"});
            this.chkEnemies.Location = new System.Drawing.Point(256, 54);
            this.chkEnemies.Name = "chkEnemies";
            this.chkEnemies.Size = new System.Drawing.Size(120, 94);
            this.chkEnemies.TabIndex = 17;
            // 
            // lblEnemies
            // 
            this.lblEnemies.AutoSize = true;
            this.lblEnemies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemies.Location = new System.Drawing.Point(252, 31);
            this.lblEnemies.Name = "lblEnemies";
            this.lblEnemies.Size = new System.Drawing.Size(71, 20);
            this.lblEnemies.TabIndex = 16;
            this.lblEnemies.Text = "Enemies";
            // 
            // chkItems
            // 
            this.chkItems.FormattingEnabled = true;
            this.chkItems.Items.AddRange(new object[] {
            "Potion",
            "Bomb",
            "Chest- Bronze Armor",
            "Chest- Iron Armor",
            "Chest- Steel Armor",
            "Chest- Mythril Armor",
            "Chest- Bronze Sword",
            "Chest- Iron Sword",
            "Chest- Steel Sword",
            "Chest- Mythril Sword"});
            this.chkItems.Location = new System.Drawing.Point(130, 54);
            this.chkItems.Name = "chkItems";
            this.chkItems.Size = new System.Drawing.Size(120, 94);
            this.chkItems.TabIndex = 15;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(126, 31);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(49, 20);
            this.lblItems.TabIndex = 14;
            this.lblItems.Text = "Items";
            // 
            // chkConnections
            // 
            this.chkConnections.FormattingEnabled = true;
            this.chkConnections.Location = new System.Drawing.Point(4, 54);
            this.chkConnections.Name = "chkConnections";
            this.chkConnections.Size = new System.Drawing.Size(120, 94);
            this.chkConnections.TabIndex = 13;
            // 
            // lblConnections
            // 
            this.lblConnections.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnections.Location = new System.Drawing.Point(0, 31);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(100, 593);
            this.lblConnections.TabIndex = 12;
            this.lblConnections.Text = "Connections";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(969, 31);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Room Builder";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(645, 84);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(75, 64);
            this.btnNewItem.TabIndex = 27;
            this.btnNewItem.Text = "New Item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnNewEnemy
            // 
            this.btnNewEnemy.Location = new System.Drawing.Point(817, 84);
            this.btnNewEnemy.Name = "btnNewEnemy";
            this.btnNewEnemy.Size = new System.Drawing.Size(75, 64);
            this.btnNewEnemy.TabIndex = 26;
            this.btnNewEnemy.Text = "New Enemy";
            this.btnNewEnemy.UseVisualStyleBackColor = true;
            this.btnNewEnemy.Click += new System.EventHandler(this.btnNewEnemy_Click);
            // 
            // lblNewItem
            // 
            this.lblNewItem.AutoSize = true;
            this.lblNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewItem.Location = new System.Drawing.Point(617, 61);
            this.lblNewItem.Name = "lblNewItem";
            this.lblNewItem.Size = new System.Drawing.Size(132, 20);
            this.lblNewItem.TabIndex = 25;
            this.lblNewItem.Text = "Make a New Item";
            // 
            // lblNewEnemy
            // 
            this.lblNewEnemy.AutoSize = true;
            this.lblNewEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEnemy.Location = new System.Drawing.Point(772, 61);
            this.lblNewEnemy.Name = "lblNewEnemy";
            this.lblNewEnemy.Size = new System.Drawing.Size(149, 20);
            this.lblNewEnemy.TabIndex = 24;
            this.lblNewEnemy.Text = "Make a New Enemy";
            // 
            // lblRoomText
            // 
            this.lblRoomText.AutoSize = true;
            this.lblRoomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomText.Location = new System.Drawing.Point(0, 252);
            this.lblRoomText.Name = "lblRoomText";
            this.lblRoomText.Size = new System.Drawing.Size(86, 20);
            this.lblRoomText.TabIndex = 28;
            this.lblRoomText.Text = "Room Text";
            // 
            // txtRoomText
            // 
            this.txtRoomText.AcceptsReturn = true;
            this.txtRoomText.AcceptsTab = true;
            this.txtRoomText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoomText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomText.Location = new System.Drawing.Point(4, 275);
            this.txtRoomText.Multiline = true;
            this.txtRoomText.Name = "txtRoomText";
            this.txtRoomText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRoomText.Size = new System.Drawing.Size(951, 255);
            this.txtRoomText.TabIndex = 29;
            // 
            // btnMakeRoom
            // 
            this.btnMakeRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeRoom.Location = new System.Drawing.Point(371, 568);
            this.btnMakeRoom.Name = "btnMakeRoom";
            this.btnMakeRoom.Size = new System.Drawing.Size(205, 44);
            this.btnMakeRoom.TabIndex = 30;
            this.btnMakeRoom.Text = "Create New Room";
            this.btnMakeRoom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Room Name";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(104, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 31);
            this.textBox1.TabIndex = 32;
            // 
            // RoomBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 624);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeRoom);
            this.Controls.Add(this.txtRoomText);
            this.Controls.Add(this.lblRoomText);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.btnNewEnemy);
            this.Controls.Add(this.lblNewItem);
            this.Controls.Add(this.lblNewEnemy);
            this.Controls.Add(this.chkSecret);
            this.Controls.Add(this.lblSecret);
            this.Controls.Add(this.chkEnemies);
            this.Controls.Add(this.lblEnemies);
            this.Controls.Add(this.chkItems);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.chkConnections);
            this.Controls.Add(this.lblConnections);
            this.Controls.Add(this.lblTitle);
            this.Name = "RoomBuilder";
            this.Text = "MAAG - RoomBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkSecret;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.CheckedListBox chkEnemies;
        private System.Windows.Forms.Label lblEnemies;
        private System.Windows.Forms.CheckedListBox chkItems;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.CheckedListBox chkConnections;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnNewEnemy;
        private System.Windows.Forms.Label lblNewItem;
        private System.Windows.Forms.Label lblNewEnemy;
        private System.Windows.Forms.Label lblRoomText;
        private System.Windows.Forms.TextBox txtRoomText;
        private System.Windows.Forms.Button btnMakeRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

