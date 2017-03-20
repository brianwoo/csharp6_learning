using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public abstract class Control
    {
        protected int xPos;
        protected int yPos;

        public Control(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public virtual void Clear()
        {
            Console.WriteLine("Clearing control");
        }

        public abstract void Draw();
    }


    public class Button : Control
    {
        private string text;

        public Button(int xPos, int yPos, string text) : base(xPos, yPos)
        {
            this.text = text;
        }

        public override void Draw()
        {
            Console.WriteLine("Button Draw");
        }
    }

    public class ListBox: Control
    {
        private List<string> list = new List<string>();

        public ListBox(int xPos, int yPos, List<string> content) : base(xPos, yPos)
        {
            this.list = content;
        }

        public override void Draw()
        {
            Console.WriteLine("ListBox Draw");
        }
    }


    public class Worker
    {
        static void Main(string[] args)
        {
            List<Control> controls = new List<Control>()
            {
                new Button(0, 100, "OK"),
                new ListBox(2, 44, new List<string>()),
                new Button(12, 4324, "Cancel")
            };

            foreach (Control control in controls)
            {
                control.Draw();
            }
        }
    }
}
