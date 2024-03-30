using System;
using SQLite;
namespace NewsApp.MVVM.Models
{
	public class ArticleDB
	{
            [PrimaryKey, AutoIncrement]


            public int id { get; set; }
            
            public string Author { get; set; }


            
            public string Title { get; set; }


            public string Description { get; set; }


            public string Url { get; set; }


            public string Image { get; set; }

            public DateTime PublishedAt { get; set; }

            public string Content { get; set; }

    }
}

