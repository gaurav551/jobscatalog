// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/**
* Author: LimpidThemes
* Version: 1.0
* Description: Javascript file for the Pathshala Dashboard Template
* Date: 16-07-2017
**/

/**********************************************************
		BEGIN: MENU TOGGLE
**********************************************************/
//Like Button
let button = document.querySelector(".like-button");

button.addEventListener("click", function(e) {
  e.preventDefault();
  this.classList.toggle("active");
  this.classList.add("animated");
  generateClones(this);
  var compId = $('#compId').val();
			$.ajax({
				url: '/Company/Like/' + compId,
				cache: false,
				method: 'GET',
				success: function (response) {
					Snackbar.show({
							text: response.responseText,
							backgroundColor: "black",
							textColor: "white",
							actionText: "Dismiss"
						}

					);
				},
				error: function () {
					Snackbar.show({
							text: "You need to Login to Like Company",
							backgroundColor: "black",
							textColor: "white",
							actionText: "Dismiss"
						}

					);
				}
			});
});


function generateClones(button) {
  let clones = randomInt(2, 4);
  for (let it = 1; it <= clones; it++) {
    let clone = button.querySelector("svg").cloneNode(true),
      size = randomInt(5, 16);
    button.appendChild(clone);
    clone.setAttribute("width", size);
    clone.setAttribute("height", size);
    clone.style.position = "absolute";
    clone.style.transition =
      "transform 0.5s cubic-bezier(0.12, 0.74, 0.58, 0.99) 0.3s, opacity 1s ease-out .5s";
    let animTimeout = setTimeout(function() {
      clearTimeout(animTimeout);
      clone.style.transform =
        "translate3d(" +
        (plusOrMinus() * randomInt(10, 25)) +
        "px," +
        (plusOrMinus() * randomInt(10, 25)) +
        "px,0)";
      clone.style.opacity = 0;
    }, 1);
    let removeNodeTimeout = setTimeout(function() {
      clone.parentNode.removeChild(clone);
      clearTimeout(removeNodeTimeout);
    }, 900);
    let removeClassTimeout = setTimeout( function() {
      button.classList.remove("animated")
    }, 600);
  }
}


function plusOrMinus() {
  return Math.random() < 0.5 ? -1 : 1;
}

function randomInt(min, max) {
  return Math.floor(Math.random() * (max - min + 1) + min);
}
