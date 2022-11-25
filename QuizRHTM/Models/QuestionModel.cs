using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace QuizRHTM.Models
{
	public partial class QuestionModel
	{
		public List<ReplyModel> Replies { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
	}
}

