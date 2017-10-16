// JavaScript Document
var sum1, sum2, sum3, summoney=0, totalarea=0;
function myFunction(){
	    "use strict";
	var length1, width1, unit1;
	
	length1=document.getElementById("l1").value;
	width1=document.getElementById("w1").value;
	unit1 = document.getElementById("u1").value;
	if(length1>=0 && width1>=0 && unit1>=0){
	var area1 = length1* width1;
	sum1 = area1*5.0;
	summoney=sum1+summoney;
	document.getElementById("Rec1").innerHTML=length1;
	document.getElementById("Rec2").innerHTML=width1;
	document.getElementById("Rec3").innerHTML=area1;
	document.getElementById("Rec4").innerHTML=sum1;
	document.getElementById("nr1").innerHTML=unit1;
	document.getElementById("nr2").innerHTML=unit1;
	document.getElementById("Rec5").innerHTML=unit1*area1;
	document.getElementById("Rec6").innerHTML=unit1*area1*5.0;
	return area1*unit1;}
	else{
		document.getElementById("Err").innerHTML="Length, Width and Unit cannot be negative.";}
	
}

function myFunction2(){
	    "use strict";
	var radius1, unit2;
	
	radius1=document.getElementById("r1").value;
	unit2 = document.getElementById("u2").value;
	if(radius1>=0 && unit2>=0){
	var area2 = radius1* Math.PI;

	sum2 = area2*5.0;
	summoney = sum2+summoney;
	document.getElementById("Cir1").innerHTML=radius1;
	document.getElementById("Cir2").innerHTML=area2;
	document.getElementById("Cir3").innerHTML=sum2;
	document.getElementById("nc1").innerHTML=unit2;
	document.getElementById("nc2").innerHTML=unit2;
	document.getElementById("Cir4").innerHTML=unit2*area2;
	document.getElementById("Cir5").innerHTML=unit2*area2*5.0;
	return area2*unit2;}
	else{
		document.getElementById("Err").innerHTML="Radius and Unit cannot be negative.";

	}
}
function myFunction3(){
	    "use strict";
	var base1, altitude1, unit3;
	
	base1=document.getElementById("b1").value;
	altitude1=document.getElementById("a1").value;
	unit3 = document.getElementById("u3").value;
	if(base1>=0 && altitude1>=0 && unit3>=0){
	var area3 = (base1* altitude1)/2;

	sum3 = area3*5.0;
	summoney = sum3+summoney;
	document.getElementById("Tri1").innerHTML=base1;
	document.getElementById("Tri2").innerHTML=altitude1;
	document.getElementById("Tri3").innerHTML=area3;
	document.getElementById("Tri4").innerHTML=sum3;
	document.getElementById("nt1").innerHTML=unit3;
	document.getElementById("nt2").innerHTML=unit3;
	document.getElementById("Tri5").innerHTML=unit3*area3;
	document.getElementById("Tri6").innerHTML=unit3*area3*5.0;
	return area3*unit3;}
	else{
		document.getElementById("Err").innerHTML="Base, Altitude and Unit cannot be negative.";

	}
}

function getTotal(){
		    "use strict";
	totalarea = myFunction()+myFunction2()+myFunction3();
	document.getElementById("totalarea").innerHTML= totalarea;
	summoney=totalarea*5.0;
	document.getElementById("totalmoney").innerHTML= summoney;
	console.log("summ   "+summoney);

}
function myFunction4(){
	"use strict";
	document.getElementById("unit1").value=0;
	document.getElementById("unit2").value=0;
	document.getElementById("unit3").value=0;
	document.getElementById("l1").value=0;
	document.getElementById("w1").value=0;
	document.getElementById("r1").value=0;
	document.getElementById("b1").value=0;
	document.getElementById("a1").value=0;
	summoney=totalarea=0;
}
