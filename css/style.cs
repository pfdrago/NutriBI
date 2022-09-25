@import url("https://fonts.googleapis.com/css2?family=Noto+Sans&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Alegreya+Sans:wght@300&family=Open+Sans&family=Overlock&display=swap");
* {
  margin: 0;
  padding: 0;
}

a {
  text-decoration: none;
}

li {
  list-style: none;
}

.navPc {
  display: none;
}

header {
  background-color: #fdd835;
  display: flex;
  justify-content: center;
  align-items: center;
  position: fixed;
  width: 100%;
  z-index: 100;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.15);
}
header .nav-link {
  font-family: "Noto Sans", sans-serif;
  font-size: 24px;
  color: black;
}
header .ulContainer {
  text-align: center;
  margin-bottom: 10px;
  background-color: #fdd835;
  box-shadow: 0 8px 32px 0 rgba(31, 38, 135, 0.37);
  border-radius: 10px;
  border: 1px solid rgba(255, 255, 255, 0.18);
}
header .navbar {
  padding: 0 0 0 10px;
  margin: 0;
  width: 95%;
}
header .navbar .navbar-toggler {
  background-color: #c6a700;
}
header .logoContainer {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-top: 10px;
  width: 10%;
}
header .logoContainer img {
  width: 100%;
}
header .logoContainer h2 {
  color: black;
}

@media screen and (min-width: 992px) {
  .navCel {
    display: none;
  }
  header .navPc {
    display: flex;
    width: 90%;
  }
  header .navPc .logoContainer {
    width: 3%;
  }
  header .navPc .navbar-toggler {
    background-color: #fdd835;
  }
  header .navPc .offcanvas {
    background-color: beige;
  }
}
.articuloContainerPc {
  display: none;
}

.articuloContainerCel {
  padding-top: 100px;
  display: flex;
  justify-content: center;
  margin-bottom: 20px;
}
.articuloContainerCel h1 {
  font-family: "Noto Sans", sans-serif;
  color: #3c3c3c;
  font-size: 30px;
  padding-top: 20px;
}
.articuloContainerCel p {
  color: #515151;
  font-size: 1.1rem;
  font-family: "Noto Sans", sans-serif;
}

.articulo {
  display: flex;
  flex-direction: column;
  text-align: center;
  border: 2px solid black;
  width: 75%;
  background: rgba(248, 231, 28, 0.2509803922);
  box-shadow: 0 8px 32px 0 rgba(31, 38, 135, 0.37);
  border-radius: 10px;
  border: 1px solid rgba(255, 255, 255, 0.18);
}

@media screen and (min-width: 992px) {
  .articuloContainerCel {
    display: none;
  }
  .articuloContainerPc {
    display: flex;
    justify-content: center;
    padding-top: 130px;
  }
  .articuloContainerPc .articulo {
    display: flex;
    flex-direction: row;
    align-items: center;
  }
  .articuloContainerPc .articulo img {
    width: 50%;
    border-top-left-radius: 10px;
    border-end-start-radius: 10px;
  }
  .articuloContainerPc .articulo .queEsContainer {
    padding: 0 50px 0 50px;
  }
  .articuloContainerPc .articulo .queEsContainer h1 {
    padding-bottom: 20px;
    font-family: "Noto Sans", sans-serif;
    color: #3c3c3c;
    font-size: 30px;
  }
  .articuloContainerPc .articulo .queEsContainer p {
    color: #515151;
    font-size: 1.1rem;
    font-family: "Noto Sans", sans-serif;
  }
}
.sectionContainerPc {
  display: none;
}

.sectionContainerCel {
  display: flex;
  justify-content: center;
}
.sectionContainerCel .btn {
  background-color: #a5d6a7;
  border: 1px solid #75a478;
  color: white;
  width: 50%;
}
.sectionContainerCel .btn:hover {
  background-color: #8fb691;
  border: 1px solid #5e8261;
  color: white;
}

.cardsContainer {
  width: 75%;
  display: flex;
  flex-direction: column;
}

.card1Container, .card2Container, .card3Container, .card4Container {
  width: 100%;
  display: flex;
  flex-direction: column;
  text-align: center;
  background: rgba(248, 231, 28, 0.2509803922);
  box-shadow: 0 8px 32px 0 rgba(31, 38, 135, 0.37);
  border-radius: 10px;
  border: 1px solid rgba(255, 255, 255, 0.18);
  margin-bottom: 20px;
  padding: 15px 0 15px 0;
}
.card1Container h2, .card2Container h2, .card3Container h2, .card4Container h2 {
  font-family: "Noto Sans", sans-serif;
  color: #3c3c3c;
  font-size: 30px;
  padding-top: 20px;
}
.card1Container p, .card2Container p, .card3Container p, .card4Container p {
  color: #515151;
  font-size: 1.1rem;
  font-family: "Noto Sans", sans-serif;
}

.swal2-styled.swal2-confirm {
  background-color: #a5d6a7;
  border: 1px solid #75a478;
}

.swal2-styled.swal2-confirm:hover {
  background-color: #8fb691;
  border: 1px solid #5e8261;
}

@media screen and (min-width: 992px) {
  .sectionContainerCel {
    display: none;
  }
  .sectionContainerPc {
    display: flex;
    justify-content: center;
  }
  .sectionContainerPc .card1Container, .sectionContainerPc .card2Container, .sectionContainerPc .card3Container, .sectionContainerPc .card4Container {
    padding: 0;
    display: flex;
    flex-direction: row;
    margin-top: 20px;
    align-items: center;
  }
  .sectionContainerPc .card1Container .registroContainer, .sectionContainerPc .card2Container .registroContainer, .sectionContainerPc .card3Container .registroContainer, .sectionContainerPc .card4Container .registroContainer {
    display: flex;
    justify-content: center;
    flex-direction: column;
  }
  .sectionContainerPc .card1Container img, .sectionContainerPc .card2Container img, .sectionContainerPc .card3Container img, .sectionContainerPc .card4Container img {
    width: 75%;
  }
  .sectionContainerPc .card1Container .imgDer, .sectionContainerPc .card2Container .imgDer, .sectionContainerPc .card3Container .imgDer, .sectionContainerPc .card4Container .imgDer {
    border-top-right-radius: 10px;
    border-bottom-right-radius: 10px;
  }
  .sectionContainerPc .card1Container .imgIzq, .sectionContainerPc .card2Container .imgIzq, .sectionContainerPc .card3Container .imgIzq, .sectionContainerPc .card4Container .imgIzq {
    border-top-left-radius: 10px;
    border-end-start-radius: 10px;
  }
  .sectionContainerPc .card1Container h2, .sectionContainerPc .card2Container h2, .sectionContainerPc .card3Container h2, .sectionContainerPc .card4Container h2 {
    font-family: "Noto Sans", sans-serif;
    color: #3c3c3c;
    font-size: 30px;
    padding-bottom: 20px;
  }
  .sectionContainerPc .card1Container p, .sectionContainerPc .card2Container p, .sectionContainerPc .card3Container p, .sectionContainerPc .card4Container p {
    color: #515151;
    font-size: 1.1rem;
    font-family: "Noto Sans", sans-serif;
    padding-bottom: 20px;
  }
  .sectionContainerPc .card1Container .btn, .sectionContainerPc .card2Container .btn, .sectionContainerPc .card3Container .btn, .sectionContainerPc .card4Container .btn {
    background-color: #a5d6a7;
    border: 1px solid #75a478;
    color: white;
    width: 50%;
  }
  .sectionContainerPc .card1Container .btn:hover, .sectionContainerPc .card2Container .btn:hover, .sectionContainerPc .card3Container .btn:hover, .sectionContainerPc .card4Container .btn:hover {
    background-color: #8fb691;
    border: 1px solid #5e8261;
    color: white;
  }
}
.video1 {
  width: 100%;
}

.swal2-container.swal2-backdrop-show, .swal2-container.swal2-noanimation {
  background: rgba(0, 0, 0, 0.4);
  backdrop-filter: blur(3px);
  -webkit-backdrop-filter: blur(3px);
}

.footer {
  padding-top: 7px;
  display: flex;
  justify-content: center;
  align-items: center;
  border: 5px solid #ffff6b;
  background-color: #fdd835;
  border-top-right-radius: 10px;
  border-top-left-radius: 10px;
}
.footer h3 {
  font-size: 12px;
}

/*@import '../base/listas';

.instalacion {
    display: flex;
    justify-content: center;
    padding-bottom: 50px;
}

.instalacionContainer {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 75%;
    text-align: center;
    padding-top: 30px;
    background: nth($colores, 4);
    box-shadow: 0 8px 32px 0 rgba( 31, 38, 135, 0.37 );
    border-radius: 10px;
    border: 1px solid rgba( 255, 255, 255, 0.18 );
    gap: 40px;

    h3 {
        font-family: 'Noto Sans', sans-serif;
        color: nth($colores-texto, 2);
        font-size: nth($encabezados, 3);
    }

    img {
        width: 50%;
    }
}*/
.mainCard {
  width: 75%;
  box-shadow: 0 8px 32px 0 rgba(31, 38, 135, 0.37);
  border-radius: 10px;
  border: 1px solid rgba(255, 255, 255, 0.18);
  padding: 5px;
  background: #ECE9E6; /* fallback for old browsers */
  background: -webkit-linear-gradient(to right, #FFFFFF, #ECE9E6); /* Chrome 10-25, Safari 5.1-6 */
  background: linear-gradient(to right, #FFFFFF, #ECE9E6); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
}

.mainContainer {
  padding: 140px 0 50px;
  display: flex;
  justify-content: center;
}
.mainContainer p {
  text-align: center;
  color: #515151;
  font-size: 1.1rem;
  font-family: "Noto Sans", sans-serif;
  padding-bottom: 50px;
}

.h1Container {
  text-align: center;
  color: #3c3c3c;
  font-family: "Noto Sans", sans-serif;
  font-size: 30px;
}

.formularioContainer {
  display: flex;
  justify-content: center;
}

.formulario {
  width: 75%;
  padding-bottom: 110px;
}

.field {
  margin-bottom: 10px;
  display: flex;
  flex-direction: column;
}

.field label {
  color: #777;
  font-family: "Noto Sans", sans-serif;
}

/*input[type="text"] {

}*/
.btn {
  background-color: #fdd835;
  color: black;
  border: none;
}

.inputContainer {
  display: flex;
  justify-content: end;
}

.disclaimer {
  display: none;
}

/*# sourceMappingURL=style.cs.map */
