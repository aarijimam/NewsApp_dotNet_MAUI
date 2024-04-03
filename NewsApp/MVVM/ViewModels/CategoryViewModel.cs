using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NewsApp.MVVM.Models;
namespace NewsApp.MVVM.ViewModels
{
	public class CategoryViewModel
	{
		public ObservableCollection<Category> ListofCategories { get; set; }
		public CategoryViewModel()
		{
			LoadCategory();
		}

        private void LoadCategory()
        {
            ListofCategories = new ObservableCollection<Category>()
            {
	            new Category{id = 3,name = "General",key = "general"},
                new Category{id = 4,name = "Business",key = "business"},
                new Category{id = 5,name = "Tech",key = "technology"},
                new Category{id = 6,name = "Entertainment",key = "entertainment"},
                new Category{id = 7,name = "Sports",key = "sports"},
                new Category{id = 8,name = "Science",key = "science"},
                new Category{id = 9,name = "Health",key = "health"}

            };
        }
    }
}

