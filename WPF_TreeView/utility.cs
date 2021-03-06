﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

/*------------------------------------
 *Author: Pengfei Wang
 *E-mail:13671619364
 *qq: 2601339907
 * github:https://github.com/pengfeiw
 -----------------------------------*/
namespace WPF_TreeView
{
    public class TreeNodeMouseLeaveEventArgs : EventArgs
    {
        public TreeNodeMouseLeaveEventArgs(TreeNode node) {
            this._node = node;
        }

        public TreeNode Node { get { return _node; } }

        private TreeNode _node;
    }

    public class TreeNodeMouseEnterEventArgs : EventArgs
    {
        public TreeNodeMouseEnterEventArgs(TreeNode node) {
            this._node = node;
        }

        public TreeNode Node { get { return _node; } }

        private TreeNode _node;
    }

    public class TreeNodeNewBtnClickEventArgs : EventArgs
    {
        public TreeNodeNewBtnClickEventArgs(TreeNode node)
        {
            this._node = node;
        }
        public TreeNode Node { get { return _node; } }

        private TreeNode _node;
    }

    public class TreeNodeOpenBtnClickEventArgs : EventArgs
    {
        public TreeNodeOpenBtnClickEventArgs(TreeNode node)
        {
            this._node = node;
        }
        public TreeNode Node { get { return _node; } }

        private TreeNode _node;
    }
}
