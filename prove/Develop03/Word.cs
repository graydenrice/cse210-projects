public class Word{

    private string _word;
    private bool _hidden;

    public Word(string word, bool hidden){
        _word = word;
        _hidden = hidden;
    }

    public void Hide(){
        _hidden = true;
    }
    
    public void Show(){
        _hidden = false;
    }

    public bool IsHidden(){
        return _hidden;
    } 

    public string renderedText(){
        if(_hidden == true){
            return new string('_', _word.Length);
        }else{
            return _word;
        }
    }
    
}