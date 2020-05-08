using System;

namespace TestTask
{
	class DocumentWorker
	{
		public virtual void OpenDocument()
		{
			Console.WriteLine("Документ открыт");
		}
		public virtual void EditDocument()
		{
			Console.WriteLine("Редактирование документа доступно в версии Про");
		}
		public virtual void SaveDocument()
		{
			Console.WriteLine("Сохранение документа доступно в версии Про");
		}
	}
	class ProDocumentWorker : DocumentWorker
	{
		public override void EditDocument()
		{
			Console.WriteLine("Документ отредактирован");
		}
		public override void SaveDocument()
		{
			Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
		}
	}
	class ExpertDocumentWorker : ProDocumentWorker
	{
		public override void SaveDocument()
		{
			Console.WriteLine("Документ сохранен в новом формате");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string input;
			Console.WriteLine("Введите ключ доступа: ");
			//ProDocumentWorker - pro
			//ExpertDocumentWorker - exp
			//DocumentWorker - else

			input = Console.ReadLine().ToLower();

			DocumentWorker docWorker;
			if(input == "exp")
				docWorker = new ExpertDocumentWorker();
			else if(input == "pro")
				docWorker = new ProDocumentWorker();
			else docWorker = new DocumentWorker();

			docWorker.OpenDocument();
			docWorker.EditDocument();
			docWorker.SaveDocument();
		}
	}
}
