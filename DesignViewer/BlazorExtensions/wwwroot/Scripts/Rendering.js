let image = new Image();
let imageLoaded = false;
image.onload = () => imageLoaded = true;
image.src = "https://stikvk.ru/wp-content/uploads/2022/03/256-14-19.png";

export function drawImage(context, x, y, width, height) {
    const ctx = context.canvas.getContext("2d");
    if (imageLoaded) {
        ctx.drawImage(image, x, y, width, height);
    }
}