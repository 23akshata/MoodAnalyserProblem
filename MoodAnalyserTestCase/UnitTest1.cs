using MoodAnalyserProblem;
namespace MoodAnalyserTestCase
{ 
    public class Tests
    {
        MoodAnalyser moodAnalyser = new MoodAnalyser();
        [Test]
        public void GivenSadMood_WhenAnalysed_ShouldReturnSad()
        {
            string result = moodAnalyser.AnalyseMood("I Am In Sad Mood.");
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenHappyMood_WhenAnalysed_ShouldReturnHappy()
        {
            string result = moodAnalyser.AnalyseMood("I Am In Happy Mood.");
            Assert.AreEqual(result, "Happy");
        }
    }
}