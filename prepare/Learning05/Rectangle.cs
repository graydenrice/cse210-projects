public class Rectangle : Shape{

    private int _length;
    private int _width;

    public Rectangle(int length, int width, string color) : base(color){
        _length = length;
        _width = width;
    }
    
    public override double GetArea(){
        return _length * _width;
    }
}