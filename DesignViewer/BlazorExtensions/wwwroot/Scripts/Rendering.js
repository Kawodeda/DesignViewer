export function drawImage(context, image, x, y, xScale, yScale) {
    const ctx = getCanvasContext(context);
    const width = image.naturalWidth * xScale;
    const height = image.naturalHeight * yScale;
    ctx.drawImage(image, x, y, width, height);
}

function getCanvasContext(context) {
    return context.canvas.getContext("2d");
}