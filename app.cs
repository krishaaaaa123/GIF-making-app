html, body {
	width: 100%;
	height: 100%;
	border: 0;
	margin: 0;
	padding: 0;
	font-family: "HelveticaNeue-Light", "Helvetica Neue Light", "Helvetica Neue", Helvetica, Arial, "Lucida Grande", sans-serif;
	background: black;
	color: white;
}
a {
	color: hsl(150, 100%, 50%);
}

img {
	margin: 5px;
}
img.frame {
	max-width: 64px;
	max-height: 64px;
}
img.frame.poof {
	opacity: 0;
	-webkit-transition: all 0.5s ease-in-out;
	-moz-transition: all 0.5s ease-in-out;
	-o-transition: all 0.5s ease-in-out;
	transition: all 0.5s ease-in-out;
	max-width: 0px;
	max-height: 0px;
	margin: 0px;
}

#frames, #results {
	background: rgba(255,255,255,0.1);
	box-shadow: 0 0 15px rgba(255,255,255,0.3) inset;
}

#error {
	color: red;
}

button.working {
	opacity: 0.8;
}

::-webkit-selection {
	background: hsla(150, 100%, 60%, 0.5);
}
::selection {
	background: hsla(150, 100%, 60%, 0.5);
}
#error::-webkit-selection {
	background: hsla(0, 100%, 60%, 0.8);
}
#error::selection {
	background: hsla(0, 100%, 60%, 0.5);
}
