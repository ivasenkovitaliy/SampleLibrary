namespace SampleLibrary.Forms
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
            this.components = new System.ComponentModel.Container();
            this.categoryTreeView = new System.Windows.Forms.TreeView();
            this.usersListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryTreeView
            // 
            this.categoryTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryTreeView.Location = new System.Drawing.Point(0, 0);
            this.categoryTreeView.Name = "categoryTreeView";
            this.categoryTreeView.Size = new System.Drawing.Size(300, 462);
            this.categoryTreeView.TabIndex = 0;
            // 
            // usersListView
            // 
            this.usersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.usersListView.ContextMenuStrip = this.userContextMenu;
            this.usersListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.usersListView.Location = new System.Drawing.Point(300, 0);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(255, 462);
            this.usersListView.TabIndex = 1;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати користувача";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Text = "Ім\'я";
            this.name.Width = 242;
            // 
            // userContextMenu
            // 
            this.userContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.userContextMenu.Name = "userContextMenu";
            this.userContextMenu.Size = new System.Drawing.Size(153, 70);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.редагуватиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usersListView);
            this.Controls.Add(this.categoryTreeView);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.userContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView categoryTreeView;
        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ContextMenuStrip userContextMenu;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;

    }
}

