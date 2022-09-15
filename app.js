const btn1 = document.querySelector('#btn1')
const btn2 = document.querySelector('#btn2')
const btn3 = document.querySelector('#btn3')
const btn4 = document.querySelector('#btn4')

btn1.addEventListener('click', () => {
    Swal.fire({
    html: '<video class="video1" id="video1"  controls src="videos/registroyseguimiento.mp4" autoplay type="video/mp4"></video>',
    confirmButtonText: 'Cerrar'
    })
})

btn2.addEventListener('click', () => {
    Swal.fire({
    html: '<video class="video1" id="video1"  controls src="videos/prueba.mp4" autoplay type="video/mp4"></video>',
    confirmButtonText: 'Cerrar'
    })
})

btn3.addEventListener('click', () => {
    Swal.fire({
    html: '<video class="video1" id="video1"  controls src="videos/prueba.mp4" autoplay type="video/mp4"></video>',
    confirmButtonText: 'Cerrar'
    })
})

btn4.addEventListener('click', () => {
    Swal.fire({
    html: '<video class="video1" id="video1"  controls src="videos/prueba.mp4" autoplay type="video/mp4"></video>',
    confirmButtonText: 'Cerrar'
    })
})