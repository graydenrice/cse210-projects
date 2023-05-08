public class Entry
    {
        public string _prompt { get; set; }
        public string _response { get; set; }
        public string _date { get; set; }
        public string _weather {get; set;}
        public string _emotion {get; set;}

        
        public Entry(string date, string prompt, string response, string weather, string emotion)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
            _weather = weather;
            _emotion = emotion;
        }
        
        public override string ToString() {
            return $"{_date}\n Weather: {_weather}\n Emotion: {_emotion}\n{_prompt}: {_response}";
        }
        
    }