var FahrenheitTemp=0;
        var CelsiusTemp=0;
        

do{
    FahrenheitTemp=prompt("Enter Fahrenheit Temperature");
    FahrenheitTemp=parseInt(FahrenheitTemp);
    CelsiusTemp=FahrenheitTemp;
    
    
    if(FahrenheitTemp>=-100 && FahrenheitTemp<=212){
        FahrenheitTemp=(FahrenheitTemp-32) * 5/9;
    
        
        
        alert("Fahrenheit temperature is "+Math.round(CelsiusTemp) +"\n\nCelsuis temperature is "+Math.round(FahrenheitTemp));

    }else {
        
        alert("You entered "+CelsiusTemp+"\nEntry must range from -100 to +212");
    }
    
  }
        

while(FahrenheitTemp!=999);
alert("Quiting the application");