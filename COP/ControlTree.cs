using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP
{
    public partial class ControlTree : UserControl
    {
        protected Queue<string> Levels
        {
            get;
            set;
        }

        public int SelectedBranchIndex
        {
            get
            {
                {
                    if (treeView.SelectedNode != null) return treeView.SelectedNode.Index;
                    return -1;
                }
            }
            set
            {
                if (value < treeView.Nodes.Count)
                {
                    treeView.SelectedNode = treeView.Nodes[value];
                    treeView.Focus();
                }
            }
        }
        public void Clear()
        {
            treeView.Nodes.Clear();
        }
        public T GetSelectedObject<T>() where T : class, new()
        {
            T t;
            T t1;
            Type propertyType;
            if (treeView.SelectedNode != null && Levels != null && treeView.SelectedNode.Nodes.Count <= 0)
            {
                Stack<string> strs = new Stack<string>();
                for (TreeNode i = treeView.SelectedNode; i != null; i = i.Parent)
                {
                    strs.Push(i.Text);
                }
                if (strs.Count == Levels.Count)
                {
                    T t2 = Activator.CreateInstance<T>();
                    foreach (string nodeName in Levels)
                    {
                        PropertyInfo property = t2.GetType().GetProperty(nodeName);
                        string str = strs.Pop();
                        if (property != null)
                        {
                            PropertyInfo propertyInfo = property;
                            object obj = t2;
                            string str1 = str;
                            if (property != null)
                            {
                                propertyType = property.PropertyType;
                            }
                            else
                            {
                                propertyType = null;
                            }
                            propertyInfo.SetValue(obj, Convert.ChangeType(str1, propertyType));
                        }
                    }
                    t1 = t2;
                }
                else
                {
                    t = default;
                    t1 = t;
                }
            }
            else
            {
                t = default;
                t1 = t;
            }
            return t1;
        }

        public ControlTree()
        {
            InitializeComponent();
        }
        public void LoadConfig(Queue<String> levels)
        {
            if (levels != null)
            {
                Levels = levels;
            }

        }

        public void AddItems<T>(List<T> items) where T : class, new()
        {
            foreach (var item in items)
            {
                var itemType = item.GetType();
                var currentLevel = treeView.Nodes;
                for (int i = 0; i < Levels.Count; i++)
                {
                    var propertyInfo = itemType.GetProperty(Levels.ElementAt(i));
                    if (propertyInfo != null)
                    {
                        var propertyValue = (string)propertyInfo.GetValue(item);
                        if (!currentLevel.ContainsKey(propertyValue) || treeView.Nodes[i].Index == treeView.Nodes.Count - 1)
                        {
                            currentLevel.Add(propertyValue, propertyValue);
                        }
                        var nextLevels = currentLevel.Find(propertyValue, false);
                        currentLevel = nextLevels[nextLevels.Length - 1].Nodes;
                    }
                }
            }
        }
    }
}
