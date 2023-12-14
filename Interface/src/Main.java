
//interface Printable {
//    void print();
//}
//class Point implements Printable{
//    private int x, y;
//    Point(int x, int y){
//        set(x, y);
//    }
//    public void set(int x, int y){
//        this.x = x;
//        this.y = y;
//
//    }
//    public void print() {
//        System.out.printf("(%d,%d)%n", x, y);
//    }
//}
//class Text implements Printable{
//    private String text;
//    Text(String text) {
//        this.text = text;
//    }
//    public void print(){
//        System.out.println(text);
//    }
//}

interface Date {
    int getYear();
    String getMonth();
    int getDay();
    void print();
}
interface Time{
    int getHours();
    int getMinutes();
    void print();
}
class DateTime implements Date, Time {
    private int hours, minutes, year, day, hour;
    private String month;
    DateTime(int year, String month, int day, int hours, int minutes){
        this.year = year;
        this.month = month;
        this.day = day;
        this.hours = hours;
        this.minutes = minutes;
    }
    public int getYear(){
        return year;
    }
    public String getMonth(){
        return month;
    }
    public int getDay(){
        return day;
    }
    public int getHours(){
        return hours;
    }
    public int getMinutes(){
        return minutes;
    }
    public void print(){
        System.out.printf("%d %s %d %02d:%2d%n", year, month, day, hours, minutes);;
    }
}

public class Main {
    public static void main(String[] args) {
//        Printable point = new Point(1, 2);
//        point.print();
//        Printable text = new Text("Some Text");
//        text.print();
        DateTime javaLecture = new DateTime(2023, "December", 14, 8, 30);
        javaLecture.print();
    }
}