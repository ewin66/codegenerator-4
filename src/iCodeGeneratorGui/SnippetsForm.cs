﻿using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace iCodeGenerator.iCodeGeneratorGui
{
    public partial class SnippetsForm : DockContent
    {
        public SnippetsForm()
        {
            InitializeComponent();
            LoadSnippets();
        }

		private void LoadSnippets()
		{
			var snippetsHelper = new SnippetsHelper();
			foreach (string key in snippetsHelper.Snippets.Keys)
			{
				AddSnippetButton(key);
			}
		}

		private void AddSnippetButton(string s)
		{
			var button = new Button
			{
			    Text = s,
			    Dock = DockStyle.Top,
			    FlatStyle = FlatStyle.Popup,
			    Font = new Font("Microsoft Sans Serif",
			        7.2567F,
			        FontStyle.Regular,
			        GraphicsUnit.Point, 0)
			};
		    button.Click += ButtonClick;
			Controls.Add(button);
		}

		public delegate void SnippetEventHandler(object sender, SnippetEventArgs args);
        public event SnippetEventHandler SnippetSelected;

	    protected virtual void OnSnippetSelected(SnippetEventArgs args)
		{
			if(SnippetSelected != null)
			{
				SnippetSelected(this,args);
			}
		}

        private void ButtonClick(object sender, EventArgs e)
        {
            var b = (Button) sender;
            var args = new SnippetEventArgs(b.Text);
            SnippetSelected(this,args);
            //throwEvent(b.Text);
        }
    }
}
