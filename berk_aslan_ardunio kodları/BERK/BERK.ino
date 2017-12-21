
#include <LiquidCrystal.h>
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
#include <dht11.h>
dht11 DHT11;

int nem=A0;
int deger;



const int lm35Pin = A1;
const int sicaklikLed=22;
float sicaklik;
float analogDeger;

int motorIn1=50;
int motorIn2=52;
int motorDurumu=0;


void setup()
{
 // analog pinler Arduino'da otomatik olarak giriş pin modunda olduğu için 
 // burada pinmodunu ayarlamaya gerek kalmıyor
 lcd.begin(16, 2);
Serial.begin(9600);   // probtan gelen verileri okumak için seri monitörü başlattık
// pinMode(prob,INPUT);
 pinMode(lm35Pin, INPUT);
 pinMode(sicaklikLed, OUTPUT);
 
 DHT11.attach(A1);
 motorSetup(); 
 
}

void loop()
{

 sicaklikSensor();
 nemSensor();
}

void sicaklikSensor()
{
  int chk = DHT11.read();


lcd.clear();
lcd.setCursor(0,0);
lcd.print("Derece :");
lcd.print((float)DHT11.temperature,0);
lcd.print(char(223));
lcd.print("C");
String kod="1";
//String sicaklik = (float));
String sonuc=kod+DHT11.temperature;
Serial.println(sonuc);
if((float)DHT11.temperature>25)
{
digitalWrite(sicaklikLed,HIGH);
lcd.setCursor(0,1);
    lcd.print("Sicaklik Yuksek");
}
 
else
{
digitalWrite(sicaklikLed,LOW);
lcd.setCursor(0,1);
    lcd.print("Sicaklik Dusuk");
}
delay(5000);
}

void nemSensor()
{
   deger = analogRead(nem);
   deger = map(deger,0,1023,100,0);
   lcd.clear();
   lcd.setCursor(0,0);
   lcd.print("Nem : ");
   lcd.print("% ");
   lcd.print(deger);
//   String kod2="2";
//   String sonuc2 = kod2+deger;
   Serial.println(deger);
   if(deger<20)
   {
    lcd.setCursor(0,1);
    lcd.print("Nem Orani Dusuk");
    motorAc();
   }
   else if(deger>20 && deger<40)
   {
    lcd.setCursor(0,1);
    lcd.print("Nem Orani Normal");
    motorKapat();
   }
   else if(deger>40)
   {
    lcd.setCursor(0,1);
    lcd.print("Nem Orani Yuksek");
    motorKapat();
   }
   delay(5000);

}

void motorSetup()
{
  pinMode(motorIn1, OUTPUT);
  pinMode(motorIn2, OUTPUT);
}

void motorAc()
{
  digitalWrite(motorIn1, HIGH);
  digitalWrite(motorIn2, LOW);
}
void motorKapat()
{
  digitalWrite(motorIn1, LOW);
  digitalWrite(motorIn2, LOW);
}

