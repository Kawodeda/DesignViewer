export function callRequestAnimationFrame(instance) {
    window.requestAnimationFrame((timeStamp) => {
        instance.invokeMethodAsync('ViewerRenderLoop', timeStamp);
    });
}

export function fileLog(bytes) {
    console.log(bytes);
    const blob = new Blob([bytes.buffer], { type: 'image/png' });
    console.log(blob);
    const image = new Image();
    image.src = URL.createObjectURL(blob);
    image.onload = () => {
        image.width = image.naturalWidth / 5;
        image.height = image.naturalHeight / 5;
        const muda = document.getElementsByTagName("canvas");
        muda.item(0).getContext("2d").drawImage(image, 10, 10);
    };
    console.log(image);
}