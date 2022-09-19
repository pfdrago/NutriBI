const btn = document.getElementById('button');

document.getElementById('form')
 .addEventListener('submit', function(event) {
   event.preventDefault();

   btn.value = 'Enviando...';

   const serviceID = 'default_service';
   const templateID = 'template_n3rulxo';

   emailjs.sendForm(serviceID, templateID, this)
    .then(() => {
      btn.value = 'Enviando';
      Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'Mensaje enviado',
        showConfirmButton: false,
        timer: 1500
      })
      btn.value = "Enviar"
    }, (err) => {
      btn.value = 'Send Email';
      Swal.fire({
        icon: 'error',
        title: 'Ups...',
        text: 'El mensaje no se pudo enviar, revise su conexión a internet',
      })
    });
});