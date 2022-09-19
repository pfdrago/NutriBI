const btn = document.getElementById('button');
const nombre = document.getElementById('from_name')
const mail = document.getElementById('email_id')
const mensaje = document.getElementById('message')

message


document.getElementById('form')

 .addEventListener('submit', function(event) {
   event.preventDefault();

   if (nombre.value !="" & mail.value !="" & mensaje.value!="") {

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
      btn.value = 'Enviar';
      Swal.fire({
        icon: 'error',
        title: 'Ups...',
        text: 'El mensaje no se pudo enviar, revise su conexión a internet',
      })
    });
  }

  else {
    const Toast = Swal.mixin({
      toast: true,
      position: 'top',
      showConfirmButton: false,
      timer: 2000,
      timerProgressBar: true,
      didOpen: (toast) => {
        toast.addEventListener('mouseenter', Swal.stopTimer)
        toast.addEventListener('mouseleave', Swal.resumeTimer)
      }
    })
    
    Toast.fire({
      icon: 'warning',
      title: 'Por favor completa todos los campos'
    })

  }
});