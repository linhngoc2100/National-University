// JavaScript Document
var sum1, sum2, sum3, summoney=0, totalarea=0;
function myFunction(){
	    "use strict";
	var length1, width1;
	
	length1=document.getElementById("l1").value;
	width1=document.getElementById("w1").value;
	var area1 = length1* width1;
	sum1 = area1*5.0;
	summoney=sum1+summoney;
	document.getElementById("Rec1").innerHTML=length1;
	document.getElementById("Rec2").innerHTML=width1;
	document.getElementById("Rec3").innerHTML=area1;
	document.getElementById("Rec4").innerHTML=sum1;
	return area1;
	
}

function myFunction2(){
	    "use strict";
	var radius1;
	
	radius1=document.getElementById("r1").value;
	var area2 = radius1* Math.PI;

	sum2 = area2*5.0;
	summoney = sum2+summoney;
	document.getElementById("Cir1").innerHTML=radius1;
	document.getElementById("Cir2").innerHTML=area2;
	document.getElementById("Cir3").innerHTML=sum2;
	return area2;
}
function myFunction3(){
	    "use strict";
	var base1, altitude1;
	
	base1=document.getElementById("b1").value;
	altitude1=document.getElementById("a1").value;
	var area3 = (base1* altitude1)/2;

	sum3 = area3*5.0;
	summoney = sum3+summoney;
	document.getElementById("Tri1").innerHTML=base1;
	document.getElementById("Tri2").innerHTML=altitude1;
	document.getElementById("Tri3").innerHTML=area3;
	document.getElementById("Tri4").innerHTML=sum3;
	return area3;
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
	document.getElementById("l1").value=0;
	document.getElementById("w1").value=0;
	document.getElementById("r1").value=0;
	document.getElementById("b1").value=0;
	document.getElementById("a1").value=0;
	summoney=totalarea=0;
}
