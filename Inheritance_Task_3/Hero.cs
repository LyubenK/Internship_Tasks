using System;
namespace Inheritance_Task_3
{
	public class Hero
	{
		private string username;
		private int level;

		public Hero(string username, int level)
		{
			this.username = username;
			this.level = level;
		}

		public string Username { get; }

		public int Level { get; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

