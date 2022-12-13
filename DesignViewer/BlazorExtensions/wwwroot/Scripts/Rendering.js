export function drawImage(context, x, y, width, height) {
    const ctx = context.canvas.getContext("2d");
    if (imageLoaded) {
        ctx.drawImage(image, x, y, width, height);
    }
}