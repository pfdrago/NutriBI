/*const btn1 = document.querySelector('#btn1')
const videoContainer = document.querySelector('#videoContainer')



btn1.addEventListener('click', () => {
    videoContainer.classList.add('videoContainer')

    videoContainer.innerHTML = '<video class="video1" id="video1"  controls src="videos/prueba.mp4" autoplay type="video/mp4"></video>'
})

videoContainer.addEventListener('click', () => {
    videoContainer.classList.remove('videoContainer')

    video1.classList.remove('video1')
    video1.classList.add('video1-off')
})*/

const btn1 = document.querySelector('#btn1')

btn1.addEventListener('click', () => {
    

    Swal.fire({
        html: '<video class="video1" id="video1"  controls src="videos/prueba.mp4" autoplay type="video/mp4"></video>',
        imageWidth: 400,
        imageHeight: 200,
        imageAlt: 'Custom image',
      })
})
