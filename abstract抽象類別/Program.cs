using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract抽象類別
{
	internal class Program
	{
		//abstract抽象類別，無法new該物件，method寫成abstract，不能寫{ }及作用，會強迫子類別一定要實作override，並且method的參數要一致
		static void Main(string[] args)
		{
			//file test1 = new fileSave();
			//test1.Save("dd");
			//file test2 = new DatabaseSave();
			//test2.Load(202);
			var test3=Getfile();
			test3.Save("Hi");
		}
		static file Getfile() 
		{
			//return new fileSave();
			return new DatabaseSave();
		}
	}
	public abstract class file
	{
		public int id { get; set; }
		public abstract string Save(string message);
		public abstract void Load(int id);
	}
	public class fileSave : file
	{
		public override void Load(int id)
		{
			
		}

		public override string Save(string message) => "";
		
	}
	public class DatabaseSave : file
	{
		public override void Load(int id)
		{
			throw new NotImplementedException();
		}

		public override string Save(string message)
		{
			throw new NotImplementedException();
		}
	}
}
