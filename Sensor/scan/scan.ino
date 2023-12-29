#include <Adafruit_Fingerprint.h>
#include <SoftwareSerial.h>
SoftwareSerial mySerial(2, 3);

Adafruit_Fingerprint finger = Adafruit_Fingerprint(&mySerial);
int x;

void setup()  
{
  Serial.begin(9600);
  while (!Serial);  
    delay(100);
    finger.begin(57600);
  }

void loop()                     
{
  getFingerprintIDez();
  delay(50);           
}

uint8_t getFingerprintID() {
        uint8_t p = finger.getImage();
                p = finger.image2Tz();
                p = finger.fingerFastSearch();
                            }


int getFingerprintIDez() {
  uint8_t p = finger.getImage();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.image2Tz();
  if (p != FINGERPRINT_OK)  return -1;

  p = finger.fingerFastSearch();
  if (p != FINGERPRINT_OK)  return -1;

          if(finger.fingerID==1){ x=12786; }
     else if(finger.fingerID==2){ x=31758; }
     else if(finger.fingerID==3){ x=23894; }
     else if(finger.fingerID==4){ x=12436; }
     else if(finger.fingerID==2){ x=22894; }
     else if(finger.fingerID==3){ x=32418; }
     else if(finger.fingerID==4){ x=32098; }
     else if(finger.fingerID==2){ x=19234; }
     else if(finger.fingerID==3){ x=19802; }
     else if(finger.fingerID==4){ x=12354; }
     else if(finger.fingerID==2){ x=23989; }
     else if(finger.fingerID==3){ x=24680; }
     else if(finger.fingerID==4){ x=31912; }
     else if(finger.fingerID==2){ x=26783; }
     else if(finger.fingerID==3){ x=15908; }
     else if(finger.fingerID==4){ x=10045; }
     else if(finger.fingerID==2){ x=17893; }
     else if(finger.fingerID==3){ x=23022; }
     else if(finger.fingerID==4){ x=31984; }
     else if(finger.fingerID==2){ x=29804; }
     else if(finger.fingerID==3){ x=33862; }
     else if(finger.fingerID==4){ x=19941; }
     else if(finger.fingerID==2){ x=31902; }
     else if(finger.fingerID==3){ x=28904; }
     else if(finger.fingerID==4){ x=17383; }
    
  
  
  Serial.println(x);
  //Serial.println("\n");
  return finger.fingerID; 
  delay(1000);   
  
}
