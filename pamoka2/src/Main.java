import java.util.Scanner;

//class Fraction {
//    private int e, d;
//
//    void setFraction(int s, int v){
//        e = s;
//        d = v;
//    }
//    void print(){
//        System.out.println("e / d -> " + e / d);
//    }
//}
class Price {
    private int eur, ct;
    public Price(){
        eur = 0;
        ct = 0;
    }
    public Price(int p_eur, int p_ct){
        eur = p_eur;
        ct = p_ct;
    }
    public Price(Price original){
        eur = original.eur;
        ct = original.ct;
    }
    public void set(int e, int c) {
        this.eur = e;
        this.ct = c;
    }

    public int getEur() {
        return eur;
    }

    public int getCt() {
        return ct;
    }

    public void print() {
        System.out.print(eur + ".");
        if (ct < 10) {
            System.out.print("0");
        }
        System.out.println(ct);
    }
}
class OperatingSystem {
    private String name;
    private Price price = new Price();


    public OperatingSystem(){
        name = "N/A";
        price = new Price();
    }
    public OperatingSystem(String p_name, Price p_price){
        name = p_name;
        price = new Price(p_price);
    }
    public OperatingSystem(OperatingSystem original){
        name = original.name;
        price = new Price(original.price);
    }
    public void set(String name, Price price) {
        this.name = name;
        this.price = price;
    }

    public void print() {
        System.out.print("Operating System Name: " + name + " / ");
        price.print();
    }
}
class Computer{
    private String name;
    private Price price;
    OperatingSystem operatingSystem = new OperatingSystem();

    public Computer(){
        name = "N/A";
        price = new Price(0,0);
        operatingSystem = new OperatingSystem();
    }
    public Computer(String computerName, Price computerPrice, String osName, Price osPrice){
        name = computerName;
        price = new Price(computerPrice);
        operatingSystem = new OperatingSystem(osName, osPrice);
    }

    public void set(String computerName, Price computerPrice, String osName, Price osPrice){
        this.name = computerName;
        this.price = computerPrice;
        operatingSystem.set(osName,osPrice);
    }
    public void print(){
        System.out.println("Computer: " + name + " / ");
        price.print();
        operatingSystem.print();

    }
}


public class Main {
    public static void main(String[] args) {

        Computer computer = new Computer();
        computer.print();
        Computer realComputer = new Computer("DELL", new Price(599,99), "Windows", new Price(123, 4));
        realComputer.print();

//        OperatingSystem windows = new OperatingSystem("Windows", new Price(123,4));
//        OperatingSystem operatingSystem = new OperatingSystem();
////        operatingSystem.set("Windows", new Price(123,4));
//        windows.print();
//        operatingSystem.print();
//        System.out.println(windows);
//        System.out.println(operatingSystem);

 /*       Price pcPrice = new Price();
        pcPrice.set(567, 30);
        Price osPrice = new Price();
        osPrice.set(123, 4);
        Computer computer = new Computer();
        computer.set("DELL", pcPrice, "Windows", osPrice);
        computer.print();
*/
    }
}