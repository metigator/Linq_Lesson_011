using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared

{
	public static class QuestionBank
	{
		private static Random random = new Random();

		public static IEnumerable<Question> Randomize(int count)
		{
			if (All.Count < count) return All;
			return AllShuffled.Take(count);
		}

		public static Question PickOne()
		{
			return All[random.Next(0, All.Count)];
		}

		public static void ToQuiz(this IEnumerable<Question> questions)
		{
			foreach (var question in questions)
			{
				Console.WriteLine(question);
				Console.WriteLine();

			}
		}

		public static List<Question> GetQuestionRange(IEnumerable<int> range)
		{
			return All.Where((x, i) => range.Contains(i)).ToList();
		}

		public static List<Question> All => new List<Question>() {
			// Question #1
			new Question {
				Title = "Q #1: In the streaming stored audio/video category of audio/video services",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Files are compressed and stored on the server"
					},
					new Choice {
						Order = 2,
						Description = "A user listens to a broadcast audio and video through the internet"
					},
					new Choice {
						Order = 3,
						Description = "People use the Internet to interactively communicate with one another"
					},
					new Choice {
						Order = 4,
						Description = "None of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #2
			new Question {
				Title = "Q #2: In the streaming live audio/video category of audio/video services",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Files are compressed and stored on the server"
					},
					new Choice {
						Order = 2,
						Description = "A user listens to a broadcast audio and video through the internet"
					},
					new Choice {
						Order = 3,
						Description = "People use the Internet to interactively communicate with one another"
					},
					new Choice {
						Order = 4,
						Description = "None of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #3
			new Question {
				Title = "Q #3: In the interactive audio/video category of audio/video services",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Files are compressed and stored on the server"
					},
					new Choice {
						Order = 2,
						Description = "A user listens to a broadcast audio and video through the internet"
					},
					new Choice {
						Order = 3,
						Description = "People use the Internet to interactively communicate with one another"
					},
					new Choice {
						Order = 4,
						Description = "None of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #4
			new Question {
				Title = "Q #4: Streaming stored audio/video is sometimes referred to as on-demand audio/video",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #5
			new Question {
				Title = "Q #5: An example of streaming stored audio/video is Internet radio",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #6
			new Question {
				Title = "Q #6: Streaming live audio/video refers to on-demand requests for compressed audio/video",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #7
			new Question {
				Title = "Q #7: An example of interactive audio/video is Internet teleconferencing",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #8
			new Question {
				Title = "Q #8: A raw piece of information, whether audio or video, must be compressed and then digitized",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #9
			new Question {
				Title = "Q #9: A raw piece of information, whether audio or video, must be digitized and then compressed",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #10
			new Question {
				Title = "Q #10: Digitization refers to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Conversion to a stream of numbers, and preferably these numbers should be integers for efficiency"
					},
					new Choice {
						Order = 2,
						Description = "The process of coding that will effectively reduce the total number of bits needed to represent certain information"
					},
					new Choice {
						Order = 3,
						Description = "The process of converting information into an analog format"
					},
					new Choice {
						Order = 4,
						Description = "Conversion to a stream of numbers, and preferably these numbers should be decimals for efficiency"
					}
				},
				CorrectAnswer = 1
			},
			// Question #11
			new Question {
				Title = "Q #11: Compression refers to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Conversion to a stream of numbers, and preferably these numbers should be integers for efficiency"
					},
					new Choice {
						Order = 2,
						Description = "The process of coding that will effectively reduce the total number of bits needed to represent certain information"
					},
					new Choice {
						Order = 3,
						Description = "The process of converting information into an analog format"
					},
					new Choice {
						Order = 4,
						Description = "Conversion to a stream of numbers, and preferably these numbers should be decimals for efficiency"
					}
				},
				CorrectAnswer = 1
			},
			// Question #12
			new Question {
				Title = "Q #12: Analog frequencies represents the sound frequency as a function of time",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #13
			new Question {
				Title = "Q #13: Analog frequencies represents the sound amplitude as a function of time",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #14
			new Question {
				Title = "Q #14: To digitize an analog signal, the signal must be sampled in the dimension of time, as well as the dimension of amplitude",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #15
			new Question {
				Title = "Q #15: To digitize an analog signal, the signal must be sampled in the dimension of time, as well as the dimension of frequency",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #16
			new Question {
				Title = "Q #16: Quantization refers to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Sampling in the voltage dimension"
					},
					new Choice {
						Order = 2,
						Description = "Sampling in the frequency dimension"
					},
					new Choice {
						Order = 3,
						Description = "Sampling in the time dimension"
					},
					new Choice {
						Order = 4,
						Description = "Sampling in the bitrate dimension"
					}
				},
				CorrectAnswer = 1
			},
			// Question #17
			new Question {
				Title = "Q #17: Sampling referes to the process of sampling the time dimension",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #18
			new Question {
				Title = "Q #18: Sampling referes to the process of sampling the amplitude dimension",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #19
			new Question {
				Title = "Q #19: Nyquist thereom states",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "If the highest frequency of the signal is f, we need to sample the signal 2f times per second"
					},
					new Choice {
						Order = 2,
						Description = "If the highest frequency of the signal is f, we need to sample the signal f times per second"
					},
					new Choice {
						Order = 3,
						Description = "If the highest frequency of the signal is f, we need to sample the signal 3f times per second"
					},
					new Choice {
						Order = 4,
						Description = "If the highest frequency of the signal is f, we need to sample the signal 4f times per second"
					}
				},
				CorrectAnswer = 1
			},
			// Question #20
			new Question {
				Title = "Q #20: The process of converting from analog audio to compressed binary form sampling quantization, and encoding is known as:",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Pulse code modulation"
					},
					new Choice {
						Order = 2,
						Description = "Polar quantization"
					},
					new Choice {
						Order = 3,
						Description = "Pulse code quantization"
					},
					new Choice {
						Order = 4,
						Description = "Polar code modulation"
					}
				},
				CorrectAnswer = 1
			},
			// Question #21
			new Question {
				Title = "Q #21: A video consists of a sequence of frames",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #22
			new Question {
				Title = "Q #22: The standard number of frames per second of a video is 25 frames per second",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #23
			new Question {
				Title = "Q #23: In North America, a common number of frames per second _________ frames per second",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "20"
					},
					new Choice {
						Order = 2,
						Description = "35"
					},
					new Choice {
						Order = 3,
						Description = "25"
					},
					new Choice {
						Order = 4,
						Description = "30"
					}
				},
				CorrectAnswer = 1
			},
			// Question #24
			new Question {
				Title = "Q #24: To avoid a condition called flickering, a frame needs to be refreshed",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #25
			new Question {
				Title = "Q #25: Pixels are also known as picture elements",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #26
			new Question {
				Title = "Q #26: For colour TV, each pixel represents 8 bits",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #27
			new Question {
				Title = "Q #27: For black and white TV, each pixel represents 8 bits",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #28
			new Question {
				Title = "Q #28: For colour TV, each pixel designates 8 bits for each primary colour (red, blue, yellow)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #29
			new Question {
				Title = "Q #29: A video's dimensions are 1920x1080 pixels (in colour), and is played at 25 frames per second (with refreshing). This means we need a ___________ Mbps bitrate",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "944"
					},
					new Choice {
						Order = 2,
						Description = "2488"
					},
					new Choice {
						Order = 3,
						Description = "1024"
					},
					new Choice {
						Order = 4,
						Description = "2048"
					}
				},
				CorrectAnswer = 1
			},
			// Question #30
			new Question {
				Title = "Q #30: In ______________ encoding, the differences between the samples are encoded instead of encoding all the sampled values",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Predictive"
					},
					new Choice {
						Order = 2,
						Description = "Perceptual"
					},
					new Choice {
						Order = 3,
						Description = "Perpetual"
					},
					new Choice {
						Order = 4,
						Description = "Compressed"
					}
				},
				CorrectAnswer = 1
			},
			// Question #31
			new Question {
				Title = "Q #31: Predictive encoding is often used for creating CD-quality audio",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #32
			new Question {
				Title = "Q #32: Predictive encoding is often used for speech",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #33
			new Question {
				Title = "Q #33: The idea of _____________ encoding is based on the limitations of our auditory system",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Predictive"
					},
					new Choice {
						Order = 2,
						Description = "Perceptual"
					},
					new Choice {
						Order = 3,
						Description = "Perpetual"
					},
					new Choice {
						Order = 4,
						Description = "Compressed"
					}
				},
				CorrectAnswer = 1
			},
			// Question #34
			new Question {
				Title = "Q #34: Perceptual encoding is often used for creating CD-quality audio",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #35
			new Question {
				Title = "Q #35: Perceptual encoding is often used for speech",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #36
			new Question {
				Title = "Q #36: MP3 uses predictive encoding",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #37
			new Question {
				Title = "Q #37: JPEG is a standard which is used to compress images",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #38
			new Question {
				Title = "Q #38: MPEG is a standard which is used to compress audio",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #39
			new Question {
				Title = "Q #39: JPEG works by",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Changing the picture into a linear set of numbers so that redundancies can be found and removed"
					},
					new Choice {
						Order = 2,
						Description = "Partitioning the picture into I-frames, P-frames, and B-frames"
					},
					new Choice {
						Order = 3,
						Description = "Changing the colour of pixels that are similar to the colour of other pixels so they are the same"
					},
					new Choice {
						Order = 4,
						Description = "Changing the size of the picture so that it is smaller"
					}
				},
				CorrectAnswer = 1
			},
			// Question #40
			new Question {
				Title = "Q #40: The steps for JPEG compression are (in order from first to last)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "DCT, Quantization, Data Compression"
					},
					new Choice {
						Order = 2,
						Description = "Quantization, DCT, Data Compression"
					},
					new Choice {
						Order = 3,
						Description = "DCT, Data Compression, Quantization"
					},
					new Choice {
						Order = 4,
						Description = "Data Compression, Quantization, DCT"
					}
				},
				CorrectAnswer = 1
			},
			// Question #41
			new Question {
				Title = "Q #41: Discrete cosine transformation changes a block of 64 values so that the relative relationships between pixels are kept but the redundancies are revealed ",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #42
			new Question {
				Title = "Q #42: DCT is irreversable ",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #43
			new Question {
				Title = "Q #43: In DCT, the value T(0, 0) in the transformation table is called the AC value",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #44
			new Question {
				Title = "Q #44: In DCT, the value T(0, 0) in the transformation table is called the DC value",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #45
			new Question {
				Title = "Q #45: In DCT, the value T(m, n), exluding the value T(0, 0) in the transformation table, is called the AC value",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #46
			new Question {
				Title = "Q #46: In DCT, the DC values are the changes in the colours of the pixels",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #47
			new Question {
				Title = "Q #47: In DCT, the DC value is the average value (multiplied by a constant) of the pixels",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #48
			new Question {
				Title = "Q #48: JPEG compression is called \"lossy\" because of the",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "DCT phase"
					},
					new Choice {
						Order = 2,
						Description = "Quantization phase"
					},
					new Choice {
						Order = 3,
						Description = "Compression phase"
					},
					new Choice {
						Order = 4,
						Description = "JPEG is not \"lossy\""
					}
				},
				CorrectAnswer = 1
			},
			// Question #49
			new Question {
				Title = "Q #49: For JPEG compression, the compression phase is read",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "In a zigzag fashion"
					},
					new Choice {
						Order = 2,
						Description = "Row by row"
					},
					new Choice {
						Order = 3,
						Description = "Column by column"
					}
				},
				CorrectAnswer = 1
			},
			// Question #50
			new Question {
				Title = "Q #50: Compressing video means spatially compressing each frame and temporally compressing a set of frames",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #51
			new Question {
				Title = "Q #51: Spatial compression in MPEG is done with JPEG (or a modification of it)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #52
			new Question {
				Title = "Q #52: Spatial compression in MPEG is done with PNG",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #53
			new Question {
				Title = "Q #53: The 3 categories that MPEG divides its frames into are",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "I-frames, P-frames, and B-frames"
					},
					new Choice {
						Order = 2,
						Description = "A-frames, B-frames, and C-frames"
					},
					new Choice {
						Order = 3,
						Description = "B-frames, P-frames, and R-frames"
					},
					new Choice {
						Order = 4,
						Description = "T-frames, I-frames, and B-frames"
					}
				},
				CorrectAnswer = 1
			},
			// Question #54
			new Question {
				Title = "Q #54: ___________ is an independent frame that is not related to any other frame",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "I-frames"
					},
					new Choice {
						Order = 2,
						Description = "P-frames"
					},
					new Choice {
						Order = 3,
						Description = "B-frames"
					}
				},
				CorrectAnswer = 1
			},
			// Question #55
			new Question {
				Title = "Q #55: ___________ is predicted frame that is related to the preceding frame",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "I-frames"
					},
					new Choice {
						Order = 2,
						Description = "P-frames"
					},
					new Choice {
						Order = 3,
						Description = "B-frames"
					}
				},
				CorrectAnswer = 1
			},
			// Question #56
			new Question {
				Title = "Q #56: ___________ is a bidirectional frame that is related to the preceding and following frame",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "I-frames"
					},
					new Choice {
						Order = 2,
						Description = "P-frames"
					},
					new Choice {
						Order = 3,
						Description = "B-frames"
					}
				},
				CorrectAnswer = 1
			},
			// Question #57
			new Question {
				Title = "Q #57: A B-frame can be related to another B-frame",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #58
			new Question {
				Title = "Q #58: A P-frame can be related to an I-frame",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #59
			new Question {
				Title = "Q #59: When using only a web server to download an audio/video file, the file can be played before the downloading has finished",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #60
			new Question {
				Title = "Q #60: When using a web server with a metafile to download an audio/video file, the media player is directly connected to the Web server for downloading the file",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #61
			new Question {
				Title = "Q #61: When using a web server with a metafile to download an audio/video file, the Web server only stores the actual audio/video file",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #62
			new Question {
				Title = "Q #62: A problem when using a web server with a metafile to download an audio/video file is that the browser and  media player both use HTTP. ",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #63
			new Question {
				Title = "Q #63: When using a web server with a media server to download an audio/video file, the media player uses the URL in the metafile to access the media server to download the file",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #64
			new Question {
				Title = "Q #64: The protocol used to download a file from a web server to your browser should utilize TCP, in case a damaged file needs to be retransmitted",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #65
			new Question {
				Title = "Q #65: Real-Time Streaming Protocol is an in-band control protocol",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #66
			new Question {
				Title = "Q #66: Real-Time Streaming Protocol is an out-of-band control protocol",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #67
			new Question {
				Title = "Q #67: Real-Time Streaming Protocol is used to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Control the playing of audio/video"
					},
					new Choice {
						Order = 2,
						Description = "Display the video in a video player"
					},
					new Choice {
						Order = 3,
						Description = "Compress the video so that it can be efficiently downloaded from a web server"
					},
					new Choice {
						Order = 4,
						Description = "Allow users to interact with another user through the Internet"
					}
				},
				CorrectAnswer = 1
			},
			// Question #68
			new Question {
				Title = "Q #68: Real-Time Streaming Protocol defines a compression scheme for audio and video",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #69
			new Question {
				Title = "Q #69: Real-Time Streaming Protocol does not define how audio and video are encapsulated in packets for transmission over a network",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #70
			new Question {
				Title = "Q #70: Real-Time Streaming Protocol can only be transported using UDP",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #71
			new Question {
				Title = "Q #71: Real-Time Streaming Protocol does not restrict how the media player buffers the audio/video",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #72
			new Question {
				Title = "Q #72: The media stream used when streaming a video from a web server is considered in-band",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #73
			new Question {
				Title = "Q #73: Streaming ________ audio/video is multicast",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Stored"
					},
					new Choice {
						Order = 2,
						Description = "Live"
					}
				},
				CorrectAnswer = 1
			},
			// Question #74
			new Question {
				Title = "Q #74: Streaming ________ audio/video is unicast",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Stored"
					},
					new Choice {
						Order = 2,
						Description = "Live"
					}
				},
				CorrectAnswer = 1
			},
			// Question #75
			new Question {
				Title = "Q #75: When using real-time interactive audio/video, the time relationship between the packets is preserved",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #76
			new Question {
				Title = "Q #76: Jitter is the variation of packet delay",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #77
			new Question {
				Title = "Q #77: Real-time traffic in interactive audio/video does not require a playback buffer",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #78
			new Question {
				Title = "Q #78: Client-side _______________________ compensate for delay jitter",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Buffering"
					},
					new Choice {
						Order = 2,
						Description = "Playback delay"
					},
					new Choice {
						Order = 3,
						Description = "All of the above"
					},
					new Choice {
						Order = 4,
						Description = "None of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #79
			new Question {
				Title = "Q #79: RTP provides which of the following features for real-time interactive audio/video",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Mixing, multicasting, ordering"
					},
					new Choice {
						Order = 2,
						Description = "Ordering, unicasting, mixing"
					},
					new Choice {
						Order = 3,
						Description = "Timing, multicasting, retransmission"
					},
					new Choice {
						Order = 4,
						Description = "Multicasting, unicasting, ordering"
					}
				},
				CorrectAnswer = 1
			},
			// Question #80
			new Question {
				Title = "Q #80: TCP is used for real-time interactive multimedia",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #81
			new Question {
				Title = "Q #81: What protocol is used for real-time interactive multimedia",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "RTP"
					},
					new Choice {
						Order = 2,
						Description = "UDP"
					},
					new Choice {
						Order = 3,
						Description = "TCP"
					},
					new Choice {
						Order = 4,
						Description = "RTP and UDP"
					}
				},
				CorrectAnswer = 1
			},
			// Question #82
			new Question {
				Title = "Q #82: RTP does not have a delivery mechanism",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #83
			new Question {
				Title = "Q #83: RTP runs beneath UDP",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #84
			new Question {
				Title = "Q #84: RTP packet headers can have a maximum of 31 contributors because the 5-bit field allows the numbers 0-31",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #85
			new Question {
				Title = "Q #85: The sender of a audio/video stream can change the encoding on the fly",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #86
			new Question {
				Title = "Q #86: The initial sequence number of an RTP packet is 0, and is then incremented by 1 for each subsequent packet",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #87
			new Question {
				Title = "Q #87: RTP packets add a SSRC field, which",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Defines the source(s)"
					},
					new Choice {
						Order = 2,
						Description = "Defines the receiver(s)"
					},
					new Choice {
						Order = 3,
						Description = "Defines the packet quality"
					},
					new Choice {
						Order = 4,
						Description = "Defines the packet quantity"
					}
				},
				CorrectAnswer = 1
			},
			// Question #88
			new Question {
				Title = "Q #88: RTCP works in conjunction with",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "RTP"
					},
					new Choice {
						Order = 2,
						Description = "UDP"
					},
					new Choice {
						Order = 3,
						Description = "TCP"
					},
					new Choice {
						Order = 4,
						Description = "RTSP"
					}
				},
				CorrectAnswer = 1
			},
			// Question #89
			new Question {
				Title = "Q #89: RTCP is used when",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The networking application multicasts audio/video to multiple receivers from one or more senders"
					},
					new Choice {
						Order = 2,
						Description = "The sender wants the receiver to have control the playback of the audio/video"
					},
					new Choice {
						Order = 3,
						Description = "The application controls who the audio/video is sent to"
					},
					new Choice {
						Order = 4,
						Description = "The network congestion prevents users from playing the streamed multimedia without buffering"
					}
				},
				CorrectAnswer = 1
			},
			// Question #90
			new Question {
				Title = "Q #90: RTP and RTSP packets are distinguished from each other through the use of distinct port numbers",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #91
			new Question {
				Title = "Q #91: RTP and RTCP packets are distinguished from each other through the use of distinct port numbers",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #92
			new Question {
				Title = "Q #92: RTCP packets encapsulate chunks of audio or video",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #93
			new Question {
				Title = "Q #93: RTCP packets contain sender and/or receiver reports",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #94
			new Question {
				Title = "Q #94: RTCP __________________ are sent periodically by the active senders in a conference to report transmission and reception statistics for all RTP packets sent during the interval",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Sender report packets"
					},
					new Choice {
						Order = 2,
						Description = "Receiver reception packets"
					},
					new Choice {
						Order = 3,
						Description = "Source description packets"
					},
					new Choice {
						Order = 4,
						Description = "Bye messages"
					}
				},
				CorrectAnswer = 1
			},
			// Question #95
			new Question {
				Title = "Q #95: RTCP __________________ are for passive participants, those that do not send RTP packets. The report informs the sender and other receivers about the quality of service.",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Sender report packets"
					},
					new Choice {
						Order = 2,
						Description = "Receiver reception packets"
					},
					new Choice {
						Order = 3,
						Description = "Source description packets"
					},
					new Choice {
						Order = 4,
						Description = "Bye messages"
					}
				},
				CorrectAnswer = 1
			},
			// Question #96
			new Question {
				Title = "Q #96: RTCP __________________ can include the email address of the sender, the sender's name, and the application that generates the RTP stream",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Sender report packets"
					},
					new Choice {
						Order = 2,
						Description = "Receiver reception packets"
					},
					new Choice {
						Order = 3,
						Description = "Source description packets"
					},
					new Choice {
						Order = 4,
						Description = "Bye messages"
					}
				},
				CorrectAnswer = 1
			},
			// Question #97
			new Question {
				Title = "Q #97: RTCP __________________ are for an application that wants to use new applications not defined in the standard. It allows the definition of a new message type.",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Sender report packets"
					},
					new Choice {
						Order = 2,
						Description = "Receiver reception packets"
					},
					new Choice {
						Order = 3,
						Description = "Source description packets"
					},
					new Choice {
						Order = 4,
						Description = "Bye messages"
					}
				},
				CorrectAnswer = 1
			},
			// Question #98
			new Question {
				Title = "Q #98: RTCP __________________ are messages that shut down a stream",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Sender report packets"
					},
					new Choice {
						Order = 2,
						Description = "Receiver reception packets"
					},
					new Choice {
						Order = 3,
						Description = "Source description packets"
					},
					new Choice {
						Order = 4,
						Description = "Bye messages"
					}
				},
				CorrectAnswer = 1
			},
			// Question #99
			new Question {
				Title = "Q #99: RTP port numbers must be",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "An even number"
					},
					new Choice {
						Order = 2,
						Description = "An odd number"
					},
					new Choice {
						Order = 3,
						Description = "A prime number"
					}
				},
				CorrectAnswer = 1
			},
			// Question #100
			new Question {
				Title = "Q #100: RTCP port numbers must be",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "An even number"
					},
					new Choice {
						Order = 2,
						Description = "An odd number"
					},
					new Choice {
						Order = 3,
						Description = "A prime number"
					}
				},
				CorrectAnswer = 1
			},
			// Question #101
			new Question {
				Title = "Q #101: RTP port numbers must immediately follow a RTCP port number",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #102
			new Question {
				Title = "Q #102: VoIP allows communication between two parties over a ___________ network",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Packet-switched"
					},
					new Choice {
						Order = 2,
						Description = "Circuit-switched"
					}
				},
				CorrectAnswer = 1
			},
			// Question #103
			new Question {
				Title = "Q #103: What is session initiation protocol (SIP)?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "It is a standard that allows telephones on the public telephone network to talk to computers connected to the internet"
					},
					new Choice {
						Order = 2,
						Description = "It is an application layer protocol that establishes, manages, and terminates a multimedia session (call)"
					},
					new Choice {
						Order = 3,
						Description = "It is a method for implementing virtual private networks"
					},
					new Choice {
						Order = 4,
						Description = "It lets a server and client have multiple conversations over a single TCP connection"
					}
				},
				CorrectAnswer = 1
			},
			// Question #104
			new Question {
				Title = "Q #104: SIP is a text-based protocol",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #105
			new Question {
				Title = "Q #105: SIP defines the following messages",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "INVITE, ACK, BYE, OPTIONS, CANCEL, REGISTER"
					},
					new Choice {
						Order = 2,
						Description = "PING, RECEIVE, END, MESSAGE, CREATE, BYE"
					},
					new Choice {
						Order = 3,
						Description = "CREATE, RESTORE, ACK, RECEIVE, CANCEL, INVITE"
					},
					new Choice {
						Order = 4,
						Description = "HELO, ACK, WAIT, OPTIONS, BYE, CANCEL, LOGIN"
					}
				},
				CorrectAnswer = 1
			},
			// Question #106
			new Question {
				Title = "Q #106: Which of the following is a valid SIP address?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Sip:tom@201.23.45.78"
					},
					new Choice {
						Order = 2,
						Description = "Sip@tom:fhda.edu"
					},
					new Choice {
						Order = 3,
						Description = "201.23.45.78@sip:tom"
					},
					new Choice {
						Order = 4,
						Description = "Fhda.edu:sip@tom"
					}
				},
				CorrectAnswer = 1
			},
			// Question #107
			new Question {
				Title = "Q #107: Establishing a session in SIP requires a",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "2 way handshake"
					},
					new Choice {
						Order = 2,
						Description = "3 way handshake"
					},
					new Choice {
						Order = 3,
						Description = "4 way handshake"
					},
					new Choice {
						Order = 4,
						Description = "5 way handshake"
					}
				},
				CorrectAnswer = 1
			},
			// Question #108
			new Question {
				Title = "Q #108: A SIP session is terminated with the CANCEL message sent by either party",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #109
			new Question {
				Title = "Q #109: What is H.323?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "It is a standard that allows telephones on the public telephone network to talk to computers connected to the internet"
					},
					new Choice {
						Order = 2,
						Description = "It is an application layer protocol that establishes, manages, and terminates a multimedia session (call)."
					},
					new Choice {
						Order = 3,
						Description = "It defines a set of quality-of-service enhancements for wireless LAN applications through modifications to the Media Access Control (MAC) layer"
					},
					new Choice {
						Order = 4,
						Description = "It is designed to compensate for the differences between traditional packet-less communications over analog lines and packet-based transmissions which are the basis for IP communications"
					}
				},
				CorrectAnswer = 1
			},
			// Question #110
			new Question {
				Title = "Q #110: What is a gateway?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "It connects the Internet to the telephone network"
					},
					new Choice {
						Order = 2,
						Description = "It is a running instance of an application capable of accepting requests from the client and giving responses accordingly"
					},
					new Choice {
						Order = 3,
						Description = "It is an endpoint of an inter-process communication flow across a computer network"
					}
				},
				CorrectAnswer = 1
			},
			// Question #111
			new Question {
				Title = "Q #111: Which of the following are characteristic types attributed to flow",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Reliability"
					},
					new Choice {
						Order = 2,
						Description = "Delay"
					},
					new Choice {
						Order = 3,
						Description = "Jitter"
					},
					new Choice {
						Order = 4,
						Description = "Bandwidth"
					}
				},
				CorrectAnswer = 1
			},
			// Question #112
			new Question {
				Title = "Q #112: Network loss happens when the packet arrives too late for playback at the receiver",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #113
			new Question {
				Title = "Q #113: End-to-End Delay loss happens when the packet arrives too late for playback at the receiver",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #114
			new Question {
				Title = "Q #114: Multimedia networking applications are typically highly sensitive to delay",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #115
			new Question {
				Title = "Q #115: _____________ is/are needed for routers to distingush between different classes",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Packet marking"
					},
					new Choice {
						Order = 2,
						Description = "Timestamps"
					},
					new Choice {
						Order = 3,
						Description = "Network marking"
					},
					new Choice {
						Order = 4,
						Description = "Packet naming"
					}
				},
				CorrectAnswer = 1
			},
			// Question #116
			new Question {
				Title = "Q #116: _____________ is a technique used for controlling errors in data transmission over unreliable or noisy communication channels",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Interleaving"
					},
					new Choice {
						Order = 2,
						Description = "Forward-error correction"
					},
					new Choice {
						Order = 3,
						Description = "Network smoothing"
					},
					new Choice {
						Order = 4,
						Description = "Packet rescue"
					}
				},
				CorrectAnswer = 1
			},
			// Question #117
			new Question {
				Title = "Q #117: A tradeoff with interleaving is that when we increase the value of n, there is less bandwidth waste and a higher probability that 2 or more chunks will be lost",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #118
			new Question {
				Title = "Q #118: One technique for forward-error correction is for every group of N chunks create redundant chunk by exclusive ORing N original chunks",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #119
			new Question {
				Title = "Q #119: Interleaving is a technique where the idea is to send a lower quality audio stream as the redundant information with the nominal stream",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #120
			new Question {
				Title = "Q #120: Interleaving is a technique where the sender re-sequences units of audio data before transmission, so that originally adjacent units are separated by a certain distance in the transmitted stream",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #121
			new Question {
				Title = "Q #121: An advantage for interleaving is that it decreases latency",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #122
			new Question {
				Title = "Q #122: ______________ is where packets wait in a buffer (queue) until the node (router or switch) is ready to process them.",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "FIFO queuing"
					},
					new Choice {
						Order = 2,
						Description = "Priority queuing"
					},
					new Choice {
						Order = 3,
						Description = "Weighted fair queuing"
					}
				},
				CorrectAnswer = 1
			},
			// Question #123
			new Question {
				Title = "Q #123: ______________ is where packets are first assigned to a priority class. Each priority class has its own queue. The packets in the highest-priority queue are processed first. Packets in the lowest-priority queue are processed last",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "FIFO queuing"
					},
					new Choice {
						Order = 2,
						Description = "Priority queuing"
					},
					new Choice {
						Order = 3,
						Description = "Weighted fair queuing"
					}
				},
				CorrectAnswer = 1
			},
			// Question #124
			new Question {
				Title = "Q #124: ______________ is where packets are assigned to different classes and admitted to different queues. The system processes packets in each queue in a round-robin fashion with the number of packets selected from each queue based on the corresponding weight.",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "FIFO queuing"
					},
					new Choice {
						Order = 2,
						Description = "Priority queuing"
					},
					new Choice {
						Order = 3,
						Description = "Weighted fair queuing"
					}
				},
				CorrectAnswer = 1
			},
			// Question #125
			new Question {
				Title = "Q #125: With priority queuing, the system does not stop serving a queue until it is empty",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #126
			new Question {
				Title = "Q #126: What is traffic shaping?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "A mechanism to control the amount and the rate of the traffic sent to the network"
					},
					new Choice {
						Order = 2,
						Description = "A way for the system to reduce the packet flow by preventing packets from entering specified subnets"
					},
					new Choice {
						Order = 3,
						Description = "A feature where a network creates fake packets to fill router buffers to prevent new packets from arriving"
					},
					new Choice {
						Order = 4,
						Description = "A mechanism where packets are scheduled to flow through a network at specified times"
					}
				},
				CorrectAnswer = 1
			},
			// Question #127
			new Question {
				Title = "Q #127: What is a \"leaky bucket\"",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "It shapes bursty traffic into fixed-rate traffic by averaging the data rate"
					},
					new Choice {
						Order = 2,
						Description = "A mechanism that slowly eliminates packets from the network that have been looping continuously between routers"
					},
					new Choice {
						Order = 3,
						Description = "A tool for a web server to allow only 1 client at a time to download a audio/video file"
					},
					new Choice {
						Order = 4,
						Description = "A method where a packet is split up into individual bits, and sent across a network 1 bit at a time"
					}
				},
				CorrectAnswer = 1
			},
			// Question #128
			new Question {
				Title = "Q #128: A leaky bucket may drop the packets if the bucket is full.",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #129
			new Question {
				Title = "Q #129: The token bucket algorithm allows idle hosts to accumulate credit for the future in the form of tokens",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #130
			new Question {
				Title = "Q #130: The ____________ allows bursty traffic at a regulated maximum rate",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Token bucket"
					},
					new Choice {
						Order = 2,
						Description = "Leaky bucket"
					},
					new Choice {
						Order = 3,
						Description = "Half bucket"
					},
					new Choice {
						Order = 4,
						Description = "Maximum bucket"
					}
				},
				CorrectAnswer = 1
			},
			// Question #131
			new Question {
				Title = "Q #131: What is a computer that can act as both a server and/or client?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Peer"
					},
					new Choice {
						Order = 2,
						Description = "Router"
					},
					new Choice {
						Order = 3,
						Description = "Seeder"
					},
					new Choice {
						Order = 4,
						Description = "Dedicated server"
					}
				},
				CorrectAnswer = 1
			},
			// Question #132
			new Question {
				Title = "Q #132: A P2P system should consist of at least two or more peers",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #133
			new Question {
				Title = "Q #133: Peers should be able to exchange resources directly between themselves",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #134
			new Question {
				Title = "Q #134: P2P systems cannot utilize dedicated servers",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #135
			new Question {
				Title = "Q #135: A \"pure\" P2P system is",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "A P2P system without dedicated servers"
					},
					new Choice {
						Order = 2,
						Description = "A P2P system that prevents leechers from using too much bandwidth"
					},
					new Choice {
						Order = 3,
						Description = "A P2P system with dedicated servers"
					},
					new Choice {
						Order = 4,
						Description = "A P2P system that uses a dedicated web server, along with a media server to stream audio/video"
					}
				},
				CorrectAnswer = 1
			},
			// Question #136
			new Question {
				Title = "Q #136: Which of the following is not a benefit of P2P systems?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Workload is spread to all peers"
					},
					new Choice {
						Order = 2,
						Description = "Maximize system utilization"
					},
					new Choice {
						Order = 3,
						Description = "No central point of failure"
					},
					new Choice {
						Order = 4,
						Description = "Scalability"
					}
				},
				CorrectAnswer = 1
			},
			// Question #137
			new Question {
				Title = "Q #137: It is easier to enforce standards in P2P systems compared to client-server systems",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #138
			new Question {
				Title = "Q #138: Which of the following is not a P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #139
			new Question {
				Title = "Q #139: Which of the following is the most popular P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #140
			new Question {
				Title = "Q #140: Which P2P topology has a one centralized server with many connected clients?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #141
			new Question {
				Title = "Q #141: A single centralized server is usually able to handle high clients load",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #142
			new Question {
				Title = "Q #142: Which P2P topology uses a cluster of machines arranged in a ring to act as distributed servers?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #143
			new Question {
				Title = "Q #143: Ring systems are generally built on the assumption that the machines are all nearby on the network",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #144
			new Question {
				Title = "Q #144: Which P2P topology has a similar structure to the Domain Name Service (DNS)?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #145
			new Question {
				Title = "Q #145: Which P2P topology has a similar structure to the Network Time Protocol (NTP)?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #146
			new Question {
				Title = "Q #146: Which P2P topology allows all peers to communicate symmetrically, and have equal roles?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #147
			new Question {
				Title = "Q #147: Gnutella is an example of which P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #148
			new Question {
				Title = "Q #148: Which of the following is a combination of several P2P topologies into one system?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #149
			new Question {
				Title = "Q #149: Which hybrid topology has a ring of servers acting as the main server, with many connected clients?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized + Ring"
					},
					new Choice {
						Order = 2,
						Description = "Centralized + Hierarchical"
					},
					new Choice {
						Order = 3,
						Description = "Decentralized + Ring"
					},
					new Choice {
						Order = 4,
						Description = "Centralized + Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #150
			new Question {
				Title = "Q #150: Which hybrid topology has a set of supernodes, each with their own set of connected peers?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized + Ring"
					},
					new Choice {
						Order = 2,
						Description = "Centralized + Hierarchical"
					},
					new Choice {
						Order = 3,
						Description = "Decentralized + Ring"
					},
					new Choice {
						Order = 4,
						Description = "Centralized + Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #151
			new Question {
				Title = "Q #151: Which of the following is not an attribute of a centralized P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Managable"
					},
					new Choice {
						Order = 2,
						Description = "Coherent"
					},
					new Choice {
						Order = 3,
						Description = "Secure"
					},
					new Choice {
						Order = 4,
						Description = "Extensible"
					}
				},
				CorrectAnswer = 1
			},
			// Question #152
			new Question {
				Title = "Q #152: Which of the following is an attribute of a centralized P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Extensible"
					},
					new Choice {
						Order = 2,
						Description = "Fault Tolerant"
					},
					new Choice {
						Order = 3,
						Description = "Lawsuit-proof"
					},
					new Choice {
						Order = 4,
						Description = "Coherent"
					}
				},
				CorrectAnswer = 1
			},
			// Question #153
			new Question {
				Title = "Q #153: Which of the following is not an attribute of a ring P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Managable"
					},
					new Choice {
						Order = 2,
						Description = "Coherent"
					},
					new Choice {
						Order = 3,
						Description = "Secure"
					},
					new Choice {
						Order = 4,
						Description = "Fault Tolerant"
					}
				},
				CorrectAnswer = 1
			},
			// Question #154
			new Question {
				Title = "Q #154: Which of the following is an attribute of a ring P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Extensible"
					},
					new Choice {
						Order = 2,
						Description = "Fault Tolerant"
					},
					new Choice {
						Order = 3,
						Description = "Scalable"
					}
				},
				CorrectAnswer = 1
			},
			// Question #155
			new Question {
				Title = "Q #155: Which of the following is not an attribute of a decentralized P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Extensible"
					},
					new Choice {
						Order = 2,
						Description = "Lawsuit-proof"
					},
					new Choice {
						Order = 3,
						Description = "Managable"
					},
					new Choice {
						Order = 4,
						Description = "Fault Tolerant"
					}
				},
				CorrectAnswer = 1
			},
			// Question #156
			new Question {
				Title = "Q #156: Which of the following is an attribute of a decentralized P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Managable"
					},
					new Choice {
						Order = 2,
						Description = "Coherent"
					},
					new Choice {
						Order = 3,
						Description = "Secure"
					},
					new Choice {
						Order = 4,
						Description = "Extensible"
					}
				},
				CorrectAnswer = 1
			},
			// Question #157
			new Question {
				Title = "Q #157: Which of the following is not an attribute of a centralized + ring hybrid P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Managable"
					},
					new Choice {
						Order = 2,
						Description = "Coherent"
					},
					new Choice {
						Order = 3,
						Description = "Secure"
					},
					new Choice {
						Order = 4,
						Description = "Fault Tolerant"
					}
				},
				CorrectAnswer = 1
			},
			// Question #158
			new Question {
				Title = "Q #158: Which of the following is an attribute of a centralized + ring hybrid P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Extensible"
					},
					new Choice {
						Order = 2,
						Description = "Fault Tolerant"
					},
					new Choice {
						Order = 3,
						Description = "Lawsuit-proof"
					}
				},
				CorrectAnswer = 1
			},
			// Question #159
			new Question {
				Title = "Q #159: The centralized + ring hybrid P2P topology is a common architecture for web applications",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #160
			new Question {
				Title = "Q #160: Which of the following is not an attribute of a centralized + decentralized hybrid P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Managable"
					},
					new Choice {
						Order = 2,
						Description = "Lawsuit-proof"
					},
					new Choice {
						Order = 3,
						Description = "Fault Tolerant"
					}
				},
				CorrectAnswer = 1
			},
			// Question #161
			new Question {
				Title = "Q #161: Which of the following is an attribute of a centralized + decentralized hybrid P2P topology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Managable"
					},
					new Choice {
						Order = 2,
						Description = "Secure"
					},
					new Choice {
						Order = 3,
						Description = "Lawsuit-proof"
					}
				},
				CorrectAnswer = 1
			},
			// Question #162
			new Question {
				Title = "Q #162: Which of the following is the best topology for P2P networks?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Centralized"
					},
					new Choice {
						Order = 2,
						Description = "Ring"
					},
					new Choice {
						Order = 3,
						Description = "Hierarchical"
					},
					new Choice {
						Order = 4,
						Description = "Decentralized"
					}
				},
				CorrectAnswer = 1
			},
			// Question #163
			new Question {
				Title = "Q #163: After Napster, new file-sharing P2P systems bypass the legal problems by not holding a central directory",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #164
			new Question {
				Title = "Q #164: Which of the following is not a Gnutella protocol message?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "PING"
					},
					new Choice {
						Order = 2,
						Description = "PONG"
					},
					new Choice {
						Order = 3,
						Description = "QUERY"
					},
					new Choice {
						Order = 4,
						Description = "RESPONSE"
					}
				},
				CorrectAnswer = 1
			},
			// Question #165
			new Question {
				Title = "Q #165: Which of the following is a P2P protocol which allows peers to download a file from a group of other peers",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "BitTorrent"
					},
					new Choice {
						Order = 2,
						Description = "Gnutella"
					},
					new Choice {
						Order = 3,
						Description = "Napster"
					},
					new Choice {
						Order = 4,
						Description = "Limewire"
					}
				},
				CorrectAnswer = 1
			},
			// Question #166
			new Question {
				Title = "Q #166: A torrent is a set of all peers that take part in downloading a file using the BitTorrent protocol",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #167
			new Question {
				Title = "Q #167: The set of all peers that takes part in a torrent is refered to as a(n) _________________",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Swarm"
					},
					new Choice {
						Order = 2,
						Description = "Seed"
					},
					new Choice {
						Order = 3,
						Description = "Leech"
					},
					new Choice {
						Order = 4,
						Description = "Tracker"
					}
				},
				CorrectAnswer = 1
			},
			// Question #168
			new Question {
				Title = "Q #168: A peer in a swarm that has the complete content file is called a(n) _________________",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Swarm"
					},
					new Choice {
						Order = 2,
						Description = "Seed"
					},
					new Choice {
						Order = 3,
						Description = "Leech"
					},
					new Choice {
						Order = 4,
						Description = "Tracker"
					}
				},
				CorrectAnswer = 1
			},
			// Question #169
			new Question {
				Title = "Q #169: A peer that has only part of the file and wants to download the rest is called a(n) _________________",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Swarm"
					},
					new Choice {
						Order = 2,
						Description = "Seed"
					},
					new Choice {
						Order = 3,
						Description = "Leech"
					},
					new Choice {
						Order = 4,
						Description = "Tracker"
					}
				},
				CorrectAnswer = 1
			},
			// Question #170
			new Question {
				Title = "Q #170: A swarm is a combination of seeds and trackers",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #171
			new Question {
				Title = "Q #171: In BitTorrent, the __________ group is the list of peers that the current peer has concurrently connected to; it continuously uploads and downloads pieces from this group.",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Unchoked"
					},
					new Choice {
						Order = 2,
						Description = "Choked"
					}
				},
				CorrectAnswer = 1
			},
			// Question #172
			new Question {
				Title = "Q #172: In BitTorrent, the __________ group is the list of neighbours that the peer is not currently connected to but may connect to in the future",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Unchoked"
					},
					new Choice {
						Order = 2,
						Description = "Choked"
					}
				},
				CorrectAnswer = 1
			},
			// Question #173
			new Question {
				Title = "Q #173: In BitTorrent, optimistic choking is when the system promotes a single interested peer every 30 seconds, regardless of its uploading rate, from the choked group and flags it as unchoked",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #174
			new Question {
				Title = "Q #174: In BitTorrent, the strategy \"common-last\" is when a peer tries to first download the pieces with the fewest repeated copies amoung the neighbours",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #175
			new Question {
				Title = "Q #175: Which of the following is not a common feature of P2P applications",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Protocols are constructed at the application layer"
					},
					new Choice {
						Order = 2,
						Description = "Peers have a unique identifier"
					},
					new Choice {
						Order = 3,
						Description = "P2P protocols support some type of message-routing capability"
					},
					new Choice {
						Order = 4,
						Description = "Applications mask the IP address of peers so they cannot be tracked"
					}
				},
				CorrectAnswer = 1
			},
			// Question #176
			new Question {
				Title = "Q #176: A(n) ______________________ is the collection of peer connections in a P2P network",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Overlay"
					},
					new Choice {
						Order = 2,
						Description = "Swarm"
					},
					new Choice {
						Order = 3,
						Description = "Tracker"
					},
					new Choice {
						Order = 4,
						Description = "Torrent"
					}
				},
				CorrectAnswer = 1
			},
			// Question #177
			new Question {
				Title = "Q #177: Which of the following is not an attribute of unstructured networks?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The nodes are linked randomly"
					},
					new Choice {
						Order = 2,
						Description = "Searching is inefficient"
					},
					new Choice {
						Order = 3,
						Description = "Queries may not be resolved"
					},
					new Choice {
						Order = 4,
						Description = "Uses predefined set of rules to link nodes"
					}
				},
				CorrectAnswer = 1
			},
			// Question #178
			new Question {
				Title = "Q #178: A structured P2P network uses a predefined set of rules to link nodes so that a query can be effectively and efficiently resolved",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #179
			new Question {
				Title = "Q #179: A common technique used in unstructured P2P networks is the distributed hash table (DHT)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #180
			new Question {
				Title = "Q #180: The address space of a distributed hash table ranges from",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "0 to 2^m - 1"
					},
					new Choice {
						Order = 2,
						Description = "1 to 2^m - 1"
					},
					new Choice {
						Order = 3,
						Description = "0 to 2^m"
					},
					new Choice {
						Order = 4,
						Description = "1 to 2^m"
					}
				},
				CorrectAnswer = 1
			},
			// Question #181
			new Question {
				Title = "Q #181: A distributed hash table distributes data items among a set of nodes according to some predefined rules",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #182
			new Question {
				Title = "Q #182: The addresses in a distributed hash table are distributed in a counter-clockwise direction",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #183
			new Question {
				Title = "Q #183: Most DHT implementations use a value of m equal to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "256"
					},
					new Choice {
						Order = 2,
						Description = "128"
					},
					new Choice {
						Order = 3,
						Description = "160"
					},
					new Choice {
						Order = 4,
						Description = "150"
					}
				},
				CorrectAnswer = 1
			},
			// Question #184
			new Question {
				Title = "Q #184: The _______________ method of storing objects in the DHT address space stores the node whose ID is \"closest\" to the key in the ring",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Direct"
					},
					new Choice {
						Order = 2,
						Description = "Indirect"
					}
				},
				CorrectAnswer = 1
			},
			// Question #185
			new Question {
				Title = "Q #185: The _______________ method of storing objects in the DHT address space stores the physical object and the reference to the object in different locations (peers).",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Direct"
					},
					new Choice {
						Order = 2,
						Description = "Indirect"
					}
				},
				CorrectAnswer = 1
			},
			// Question #186
			new Question {
				Title = "Q #186: _______________ overlays in a P2P network organize nodes into a random graph, and then use floods/random walks to discover data stored by overlay nodes",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Unstructured"
					},
					new Choice {
						Order = 2,
						Description = "Structured"
					}
				},
				CorrectAnswer = 1
			},
			// Question #187
			new Question {
				Title = "Q #187: Which unstructured overlay algorithm prevents messages from circulating endlessly by attaching message identifiers/TTL values (and does not alter the TTL if the query fails)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Flooding"
					},
					new Choice {
						Order = 2,
						Description = "Expanding ring"
					},
					new Choice {
						Order = 3,
						Description = "Random walk"
					},
					new Choice {
						Order = 4,
						Description = "Pastry"
					}
				},
				CorrectAnswer = 1
			},
			// Question #188
			new Question {
				Title = "Q #188: Which unstructured overlay algorithm increases the TTL value by a small amount if the query fails?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Flooding"
					},
					new Choice {
						Order = 2,
						Description = "Expanding ring"
					},
					new Choice {
						Order = 3,
						Description = "Dijkstra"
					},
					new Choice {
						Order = 4,
						Description = "Pastry"
					}
				},
				CorrectAnswer = 1
			},
			// Question #189
			new Question {
				Title = "Q #189: Which unstructured overlay algorithm randomly traverses nodes, and decrements a TTL at each hop?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Flooding"
					},
					new Choice {
						Order = 2,
						Description = "Expanding ring"
					},
					new Choice {
						Order = 3,
						Description = "Dijkstra"
					},
					new Choice {
						Order = 4,
						Description = "Pastry"
					}
				},
				CorrectAnswer = 1
			},
			// Question #190
			new Question {
				Title = "Q #190: Random walk queries in an unstructured overlay must be carried out sequentially",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #191
			new Question {
				Title = "Q #191: _______________ overlays in a P2P network combines a specific geometrical structure with appropriate routing and maintenance mechanisms",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Unstructured"
					},
					new Choice {
						Order = 2,
						Description = "Structured"
					}
				},
				CorrectAnswer = 1
			},
			// Question #192
			new Question {
				Title = "Q #192: Which of the following is not a structured overlay protocol?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Kademlia"
					},
					new Choice {
						Order = 2,
						Description = "Chord"
					},
					new Choice {
						Order = 3,
						Description = "Pastry"
					},
					new Choice {
						Order = 4,
						Description = "Finger"
					}
				},
				CorrectAnswer = 1
			},
			// Question #193
			new Question {
				Title = "Q #193: What is a Distributed Object Location and Routing (DOLR) system?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "A P2P system that uses key-based routing"
					},
					new Choice {
						Order = 2,
						Description = "A distributed naming system for resources connected to the internet"
					},
					new Choice {
						Order = 3,
						Description = "A method of routing resources from a centralized server to a client"
					},
					new Choice {
						Order = 4,
						Description = "A client-server system which distributes files evenly across the server"
					}
				},
				CorrectAnswer = 1
			},
			// Question #194
			new Question {
				Title = "Q #194: For the Chord protocol, the closest peer with N >= k hosts the value (k, v), where k is the hash of the data name, and v is the information about the peer that has the actual object",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #195
			new Question {
				Title = "Q #195: The Pastry protocol utilizes a finger table to resolve a query/lookup",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #196
			new Question {
				Title = "Q #196: In a finger table for the Chord protocol, each node needs to know about m successor nodes and one predecessor node",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #197
			new Question {
				Title = "Q #197: What is the successor of a target key in a finger table? (N=current node, i=record number starting at 1)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Successor(N + 2^(i - 1))"
					},
					new Choice {
						Order = 2,
						Description = "Successor(N + 2^(i + 1))"
					},
					new Choice {
						Order = 3,
						Description = "Successor(N - 2^(i - 1))"
					},
					new Choice {
						Order = 4,
						Description = "Successor(N - 2^(i + 1))"
					}
				},
				CorrectAnswer = 1
			},
			// Question #198
			new Question {
				Title = "Q #198: In a finger table, a node is responsible for all keys less than the current node, but greater than the preceeding node (i.e. N > K > N - 1)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #199
			new Question {
				Title = "Q #199: Which Chord operation is used to find where an object is located among the available peers in the ring?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Lookup"
					},
					new Choice {
						Order = 2,
						Description = "Stabilize"
					},
					new Choice {
						Order = 3,
						Description = "Fix_Finger"
					},
					new Choice {
						Order = 4,
						Description = "Join"
					}
				},
				CorrectAnswer = 1
			},
			// Question #200
			new Question {
				Title = "Q #200: Which Chord operation is used to validate its information about its successor, and let the success validate its information about its predecessor?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Lookup"
					},
					new Choice {
						Order = 2,
						Description = "Stabilize"
					},
					new Choice {
						Order = 3,
						Description = "Fix_Finger"
					},
					new Choice {
						Order = 4,
						Description = "Join"
					}
				},
				CorrectAnswer = 1
			},
			// Question #201
			new Question {
				Title = "Q #201: Which Chord operation is used to update a finger table?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Lookup"
					},
					new Choice {
						Order = 2,
						Description = "Stabilize"
					},
					new Choice {
						Order = 3,
						Description = "Fix_Finger"
					},
					new Choice {
						Order = 4,
						Description = "Join"
					}
				},
				CorrectAnswer = 1
			},
			// Question #202
			new Question {
				Title = "Q #202: In the Chord protocol, when a node leaves, the data/references must be duplicated on other nodes",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #203
			new Question {
				Title = "Q #203: What is a common value for m in the Pastry protocol?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "256"
					},
					new Choice {
						Order = 2,
						Description = "128"
					},
					new Choice {
						Order = 3,
						Description = "160"
					},
					new Choice {
						Order = 4,
						Description = "150"
					}
				},
				CorrectAnswer = 1
			},
			// Question #204
			new Question {
				Title = "Q #204: In the Pastry protocol, a key is stored in the node whose identifier is numerically closest to the key",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #205
			new Question {
				Title = "Q #205: In the Pastry protocol, the number of rows in the routing table is equal to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "M / b"
					},
					new Choice {
						Order = 2,
						Description = "M * b"
					},
					new Choice {
						Order = 3,
						Description = "B / m"
					},
					new Choice {
						Order = 4,
						Description = "2^b"
					}
				},
				CorrectAnswer = 1
			},
			// Question #206
			new Question {
				Title = "Q #206: In the Pastry protocol, the number of columns in the routing table is equal to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "M / b"
					},
					new Choice {
						Order = 2,
						Description = "M * b"
					},
					new Choice {
						Order = 3,
						Description = "B / m"
					},
					new Choice {
						Order = 4,
						Description = "2^b"
					}
				},
				CorrectAnswer = 1
			},
			// Question #207
			new Question {
				Title = "Q #207: In the Pastry protocol, a cell in the routing table can contain multiple values",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #208
			new Question {
				Title = "Q #208: In the Pastry protocol, the leaf set is a list of IDs that are numerically larger than the current node ID",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #209
			new Question {
				Title = "Q #209: In the Pastry protocol, the leaf set contains _________ identifiers",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "M / b"
					},
					new Choice {
						Order = 2,
						Description = "M * b"
					},
					new Choice {
						Order = 3,
						Description = "B / m"
					},
					new Choice {
						Order = 4,
						Description = "2^b"
					}
				},
				CorrectAnswer = 1
			},
			// Question #210
			new Question {
				Title = "Q #210: Which of the following structured overlay protocols routes messages based on the distance between the nodes?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Kademlia"
					},
					new Choice {
						Order = 2,
						Description = "Chord"
					},
					new Choice {
						Order = 3,
						Description = "Pastry"
					}
				},
				CorrectAnswer = 1
			},
			// Question #211
			new Question {
				Title = "Q #211: In the Kademlia protocol, the distance between nodes is determined by bitwise",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "XOR"
					},
					new Choice {
						Order = 2,
						Description = "XAND"
					},
					new Choice {
						Order = 3,
						Description = "OR"
					},
					new Choice {
						Order = 4,
						Description = "AND"
					}
				},
				CorrectAnswer = 1
			},
			// Question #212
			new Question {
				Title = "Q #212: In the Kademlia protocol, if m=5, how many subtrees does a node divide the binary tree into?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "5"
					},
					new Choice {
						Order = 2,
						Description = "32"
					},
					new Choice {
						Order = 3,
						Description = "64"
					},
					new Choice {
						Order = 4,
						Description = "25"
					}
				},
				CorrectAnswer = 1
			},
			// Question #213
			new Question {
				Title = "Q #213: The Kademlia protocol, requires that each row in the routing table keeps at least up to __________ nodes from the corresponding subtree",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "5"
					},
					new Choice {
						Order = 2,
						Description = "10"
					},
					new Choice {
						Order = 3,
						Description = "15"
					},
					new Choice {
						Order = 4,
						Description = "20"
					}
				},
				CorrectAnswer = 1
			},
			// Question #214
			new Question {
				Title = "Q #214: In Kademlia, each row is referred to as a",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "K-bucket"
					},
					new Choice {
						Order = 2,
						Description = "N-bucket"
					},
					new Choice {
						Order = 3,
						Description = "Subrecord"
					},
					new Choice {
						Order = 4,
						Description = "Finger"
					}
				},
				CorrectAnswer = 1
			},
			// Question #215
			new Question {
				Title = "Q #215: _____________ refers to what Alice does with the message and the key to obtain a ciphertext",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Key generation"
					},
					new Choice {
						Order = 2,
						Description = "Encryption"
					},
					new Choice {
						Order = 3,
						Description = "Decryption"
					},
					new Choice {
						Order = 4,
						Description = "Signing"
					}
				},
				CorrectAnswer = 1
			},
			// Question #216
			new Question {
				Title = "Q #216: _____________ refers to what Bob does with the ciphertext and the key to obtain the plaintext",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Key generation"
					},
					new Choice {
						Order = 2,
						Description = "Encryption"
					},
					new Choice {
						Order = 3,
						Description = "Decryption"
					},
					new Choice {
						Order = 4,
						Description = "Signing"
					}
				},
				CorrectAnswer = 1
			},
			// Question #217
			new Question {
				Title = "Q #217: _____________ refers to what Alice and Bob do to create the shared secret key",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Key generation"
					},
					new Choice {
						Order = 2,
						Description = "Encryption"
					},
					new Choice {
						Order = 3,
						Description = "Decryption"
					},
					new Choice {
						Order = 4,
						Description = "Signing"
					}
				},
				CorrectAnswer = 1
			},
			// Question #218
			new Question {
				Title = "Q #218: What is cryptology?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The art and science of making and breaking \"secret codes\""
					},
					new Choice {
						Order = 2,
						Description = "Making \"secret codes\""
					},
					new Choice {
						Order = 3,
						Description = "Breaking \"secret codes\""
					},
					new Choice {
						Order = 4,
						Description = "All of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #219
			new Question {
				Title = "Q #219: What is cryptography?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The art and science of making and breaking \"secret codes\""
					},
					new Choice {
						Order = 2,
						Description = "Making \"secret codes\""
					},
					new Choice {
						Order = 3,
						Description = "Breaking \"secret codes\""
					},
					new Choice {
						Order = 4,
						Description = "All of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #220
			new Question {
				Title = "Q #220: What is cryptoanalysis?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The art and science of making and breaking \"secret codes\""
					},
					new Choice {
						Order = 2,
						Description = "Making \"secret codes\""
					},
					new Choice {
						Order = 3,
						Description = "Breaking \"secret codes\""
					},
					new Choice {
						Order = 4,
						Description = "All of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #221
			new Question {
				Title = "Q #221: What is crypto?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The art and science of making and breaking \"secret codes\""
					},
					new Choice {
						Order = 2,
						Description = "Making \"secret codes\""
					},
					new Choice {
						Order = 3,
						Description = "Breaking \"secret codes\""
					},
					new Choice {
						Order = 4,
						Description = "All of the above"
					}
				},
				CorrectAnswer = 1
			},
			// Question #222
			new Question {
				Title = "Q #222: A symmetric key cryptosystem uses ____________ to encrypt as to decrypt",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The same key"
					},
					new Choice {
						Order = 2,
						Description = "A public key and a private key"
					},
					new Choice {
						Order = 3,
						Description = "No keys"
					}
				},
				CorrectAnswer = 1
			},
			// Question #223
			new Question {
				Title = "Q #223: A public key cryptosystem uses ____________ to encrypt as to decrypt",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "The same key"
					},
					new Choice {
						Order = 2,
						Description = "A public key and a private key"
					},
					new Choice {
						Order = 3,
						Description = "No keys"
					}
				},
				CorrectAnswer = 1
			},
			// Question #224
			new Question {
				Title = "Q #224: A public key cryptosystem uses a private key to encrypt and a public key to decrypt",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #225
			new Question {
				Title = "Q #225: Polynomial time is considered infeasible",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #226
			new Question {
				Title = "Q #226: What is Kerckhoff's Principle?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Crypto algorithms are not a secret"
					},
					new Choice {
						Order = 2,
						Description = "The algebraic sum of currents in a network of conductors meeting at a point is zero"
					},
					new Choice {
						Order = 3,
						Description = "Public key encryption is more secure than symmetric key encryption"
					},
					new Choice {
						Order = 4,
						Description = "The cryptosystem should depend on the secrecy of the algorithm"
					}
				},
				CorrectAnswer = 1
			},
			// Question #227
			new Question {
				Title = "Q #227: In Ouda's Key Crypto notation, P refers to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Plaintext block"
					},
					new Choice {
						Order = 2,
						Description = "Cipertext block"
					},
					new Choice {
						Order = 3,
						Description = "Signature"
					},
					new Choice {
						Order = 4,
						Description = "Public key"
					}
				},
				CorrectAnswer = 1
			},
			// Question #228
			new Question {
				Title = "Q #228: In Ouda's Key Crypto notation, C refers to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Plaintext block"
					},
					new Choice {
						Order = 2,
						Description = "Cipertext block"
					},
					new Choice {
						Order = 3,
						Description = "Signature"
					},
					new Choice {
						Order = 4,
						Description = "Public key"
					}
				},
				CorrectAnswer = 1
			},
			// Question #229
			new Question {
				Title = "Q #229: In cryptography, C = D(P, K)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #230
			new Question {
				Title = "Q #230: In cryptography, P = D(E(P, K), K)",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #231
			new Question {
				Title = "Q #231: In Ouda's Key Crypto notation, [M]_Alice refers to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Signing a message with Alice's private key"
					},
					new Choice {
						Order = 2,
						Description = "Signing a message with Alice's public key"
					},
					new Choice {
						Order = 3,
						Description = "Encrypting a message with Alice's private key"
					},
					new Choice {
						Order = 4,
						Description = "Encrypting a message with Alice's public key"
					}
				},
				CorrectAnswer = 1
			},
			// Question #232
			new Question {
				Title = "Q #232: In Ouda's Key Crypto notation, {M}_Alice refers to",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Signing a message with Alice's private key"
					},
					new Choice {
						Order = 2,
						Description = "Signing a message with Alice's public key"
					},
					new Choice {
						Order = 3,
						Description = "Encrypting a message with Alice's private key"
					},
					new Choice {
						Order = 4,
						Description = "Encrypting a message with Alice's public key"
					}
				},
				CorrectAnswer = 1
			},
			// Question #233
			new Question {
				Title = "Q #233: In cryptography, {[M]_Alice}_Alice = M",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #234
			new Question {
				Title = "Q #234: In cryptography, {[M]_Bob}_Alice = M",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #235
			new Question {
				Title = "Q #235: A cryptographic nonce is an arbitrary number that can be used multiple times",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #236
			new Question {
				Title = "Q #236: Timestamps in cryptography must account for clock skew",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #237
			new Question {
				Title = "Q #237: For entity authentication with a public key signature, which key pair is not needed?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Encryption/decryption key pair"
					},
					new Choice {
						Order = 2,
						Description = "Signing/verifying key pair"
					},
					new Choice {
						Order = 3,
						Description = "Key exchange key pair"
					},
					new Choice {
						Order = 4,
						Description = "Session key pair"
					}
				},
				CorrectAnswer = 1
			},
			// Question #238
			new Question {
				Title = "Q #238: One session key is used per session when it is required",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "True"
					},
					new Choice {
						Order = 2,
						Description = "False"
					}
				},
				CorrectAnswer = 1
			},
			// Question #239
			new Question {
				Title = "Q #239: What is perfect forward secrecy?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "A type of encryption where a compromise of a private key can't be used to decrypt past communications"
					},
					new Choice {
						Order = 2,
						Description = "An encryption method where each bit or character of the plaintext is encrypted by combining it with the corresponding bit or character from the pad using modular addition"
					},
					new Choice {
						Order = 3,
						Description = "A type of encryption where one of the encryption keys are private and the other is public"
					},
					new Choice {
						Order = 4,
						Description = "A technique used to secure both the public and private keys when communicating insecurely"
					}
				},
				CorrectAnswer = 1
			},
			// Question #240
			new Question {
				Title = "Q #240: How can Alice and Bob ensure perfect forward secrecy?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Encrypt with the session key"
					},
					new Choice {
						Order = 2,
						Description = "Encrypt with the public key"
					},
					new Choice {
						Order = 3,
						Description = "Encrypt with the private key"
					},
					new Choice {
						Order = 4,
						Description = "Encrypt with the one time pad"
					}
				},
				CorrectAnswer = 1
			},
			// Question #241
			new Question {
				Title = "Q #241: What is Diffie-Hellman?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "A specific method of securely exchanging cryptographic keys over a public channel"
					},
					new Choice {
						Order = 2,
						Description = "A method of factoring an RSA key"
					},
					new Choice {
						Order = 3,
						Description = "An authenticated protocol for key agreement"
					},
					new Choice {
						Order = 4,
						Description = "An augmented password-authenticated key agreement"
					}
				},
				CorrectAnswer = 1
			},
			// Question #242
			new Question {
				Title = "Q #242: What is a man in the middle attack?",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "An attack where the attacker secretly relays and possibly alters the communication between two parties who believe they are directly communicating with each other"
					},
					new Choice {
						Order = 2,
						Description = "An attack where the attacker uses expired session keys to decrypt messages"
					},
					new Choice {
						Order = 3,
						Description = "An attack in which each possibility is tried until success is obtained"
					},
					new Choice {
						Order = 4,
						Description = "A known plaintext attack against double encryption with two separated keys where the attacker encrypts a plaintext with a key and \"decrypts\" the original ciphertext with another key and hopes to get the same value."
					}
				},
				CorrectAnswer = 1
			},
			// Question #243
			new Question {
				Title = "Q #243: The socket layer lives between the",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Application and transport layers"
					},
					new Choice {
						Order = 2,
						Description = "Transport and network layers"
					},
					new Choice {
						Order = 3,
						Description = "Network and link layers"
					},
					new Choice {
						Order = 4,
						Description = "Application and network layers"
					}
				},
				CorrectAnswer = 1
			},
			// Question #244
			new Question {
				Title = "Q #244: ___________ is a standard security technology for establishing an encrypted link between a server and a client",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "SSL"
					},
					new Choice {
						Order = 2,
						Description = "RSA"
					},
					new Choice {
						Order = 3,
						Description = "SHA-2"
					},
					new Choice {
						Order = 4,
						Description = "TCP"
					}
				},
				CorrectAnswer = 1
			},
			// Question #245
			new Question {
				Title = "Q #245: A ___________ is a small data file that digitally binds a cryptographic key to an organization's details. It allows secure connections from a web server to a browser",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "SSL certificate"
					},
					new Choice {
						Order = 2,
						Description = "Private key"
					},
					new Choice {
						Order = 3,
						Description = "Public key"
					},
					new Choice {
						Order = 4,
						Description = "RSA certificate"
					}
				},
				CorrectAnswer = 1
			},
			new Question {
				Title = "Q #245: What is PAN",
				Choices = new List < Choice > {
					new Choice {
						Order = 1,
						Description = "Let devices connect and communicate over the range of a person. E.g. connecting Bluetooth devices"
					},
					new Choice {
						Order = 2,
						Description = "It is a privately owned network that operates within and nearby a single building like a home, office, or factory"
					},
					new Choice {
						Order = 3,
						Description = "It is a privately owned network that operates within and nearby a single building like a home, office, or factory"
					},
					new Choice {
						Order = 4,
						Description = "It is a privately owned network that operates within and nearby a single building like a home, office, or factory"
					}
				},
				CorrectAnswer = 1
			}
		};

		private static List<Question> AllShuffled => All.OrderBy(x => random.Next()).ToList();
	}
}