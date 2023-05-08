public class Prompt{

        public List<string> _prompts = new List<string>()
            {
                "What did you learn today?",
                "What was the best part of the day?",
                "How have I seen the Hand of the Lord?",
                "What made you happy today?",
                "Where did you travel today?"
            };
        public string RandomPrompt()
            {
               Random newPrompt = new Random();
               int index = newPrompt.Next(_prompts.Count);
               return _prompts[index];
            }
}