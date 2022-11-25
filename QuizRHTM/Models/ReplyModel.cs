using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace QuizRHTM.Models
{
	[ObservableObject]
	public partial class ReplyModel
	{
        [ObservableProperty]
        public bool isSelected;
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

