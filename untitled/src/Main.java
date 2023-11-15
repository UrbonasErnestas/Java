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
    public void print() {
        System.out.print("Operating System Name: " + name + " / ");
        price.print();
    }
}
class Software {
    private String name;
    private Price price = new Price();

    public Software(){
    name = "N/A";
    price = new Price();
    }
    public Software(String p_name, Price p_price){
        name = p_name;
        price = new Price(p_price);
    }
    public void set(String name, Price price) {
        this.name = name;
        this.price = price;
    }
    public void print(){
        System.out.print("Software: " + name + " / ");
        price.print();
    }
}
class Computer{
    private String name;
    private Price price;
    OperatingSystem operatingSystem = new OperatingSystem();
    Software software = new Software();

    public Computer(String computerName, Price computerPrice, String osName, Price osPrice, String pName, Price pPrice){
        name = computerName;
        price = new Price(computerPrice);
        operatingSystem = new OperatingSystem(osName, osPrice);
        software = new Software(pName, pPrice);
    }
//    public double getTotalPrice(){
//        double totalPrice = 0.0;
//        totalPrice = price + Computer.osPrice ;
//        System.out.println(price + );
//    }

    public void print(){
        System.out.print("Computer: " + name + " / ");
        price.print();
        operatingSystem.print();
        software.print();

    }
}
public class Main {
    public static void main(String[] args) {

//        Software software = new Software();
//        software.set("Software description", new Price(1234, 56));
//        software.print();

        Computer realComputer = new Computer("Lenovo", new Price(567,30), "Windows", new Price(123, 5),
                "kazkas", new Price(1234,56));
        realComputer.print();


    }
}