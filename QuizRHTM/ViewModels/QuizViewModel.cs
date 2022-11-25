using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizRHTM.Models;

namespace QuizRHTM.ViewModels
{
	[ObservableObject]
	public partial class QuizViewModel
	{
        ObservableCollection<QuestionModel> Questions;

        [ObservableProperty]
		ObservableCollection<ReplyModel> currentReplies;

        [ObservableProperty]
        string nameQuestion;

        [ObservableProperty]
        bool isLoading;

        int IndexQuestion = 0;

		public QuizViewModel()
		{
			Questions = new ObservableCollection<QuestionModel>
			{
				new QuestionModel
				{
					Id = 1,
					Name = "Como te llamas",
					Replies = new List<ReplyModel>
					{
						new ReplyModel
						{
							Id = 1000,
							Name = "Hector"
						},
                        new ReplyModel
                        {
                            Id = 1001,
                            Name = "Rotceh"
                        },
                        new ReplyModel
                        {
                            Id = 1002,
                            Name = "Mall"
                        },
                        new ReplyModel
                        {
                            Id = 1003,
                            Name = "Ricardo"
                        },
                    }
				},
                new QuestionModel
                {
                    Id = 2,
                    Name = "Superheroe Favorito:",
                    Replies = new List<ReplyModel>
                    {
                        new ReplyModel
                        {
                            Id = 1004,
                            Name = "Spiderman"
                        },
                        new ReplyModel
                        {
                            Id = 1005,
                            Name = "Batman"
                        },
                        new ReplyModel
                        {
                            Id = 1006,
                            Name = "Iron man"
                        },
                        new ReplyModel
                        {
                            Id = 1007,
                            Name = "Flash"
                        },
                    }
                },
                new QuestionModel
                {
                    Id = 3,
                    Name = "Color Favorito",
                    Replies = new List<ReplyModel>
                    {
                        new ReplyModel
                        {
                            Id = 1008,
                            Name = "Rojo"
                        },
                        new ReplyModel
                        {
                            Id = 1009,
                            Name = "Verde"
                        },
                        new ReplyModel
                        {
                            Id = 1010,
                            Name = "Azul"
                        },
                        new ReplyModel
                        {
                            Id = 1011,
                            Name = "Naranja"
                        },
                    }
                },
                new QuestionModel
                {
                    Id = 4,
                    Name = "Ultima pregunta: Pelicula Favorita",
                    Replies = new List<ReplyModel>
                    {
                        new ReplyModel
                        {
                            Id = 1012,
                            Name = "Resident evil"
                        },
                        new ReplyModel
                        {
                            Id = 1013,
                            Name = "Sonic"
                        },
                        new ReplyModel
                        {
                            Id = 1014,
                            Name = "Uncharted"
                        },
                        new ReplyModel
                        {
                            Id = 1015,
                            Name = "Spìderman"
                        },
                    }
                },
            };
            NameQuestion = Questions.First().Name;
            CurrentReplies = Questions.First().Replies.ToObservableCollection();
		}
        
        void CleanReplies()
        {
            foreach (var reply in CurrentReplies)
            {
                reply.IsSelected = false;
            }
        }

        [Conditional("ANDROID")]
        void UpdateScreenReply()
        {
            CurrentReplies = new ObservableCollection<ReplyModel>(CurrentReplies.ToList());
        }

        [RelayCommand]
        void NextQuestion()
        {
            if (IndexQuestion >= Questions.Count -1)
                return;

            IndexQuestion++;
            CurrentReplies = new ObservableCollection<ReplyModel>(Questions[IndexQuestion].Replies);
            NameQuestion = Questions[IndexQuestion].Name;
        }

        [RelayCommand]
        void BackQuestion()
        {
            if (IndexQuestion == 0)
                return;

            IndexQuestion--;
            CurrentReplies = new ObservableCollection<ReplyModel>(Questions[IndexQuestion].Replies);
            NameQuestion = Questions[IndexQuestion].Name;
        }

        [RelayCommand]
        void SelectReply(ReplyModel reply)
        {
            CleanReplies();

            reply.IsSelected = true;

            UpdateScreenReply();
        }
    }
}

