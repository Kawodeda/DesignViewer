export function drawImage(context, image, x, y, xScale, yScale, refPointCenter = false) {
    const ctx = getCanvasContext(context);
    const width = image.naturalWidth * xScale;
    const height = image.naturalHeight * yScale;

    if (refPointCenter) {
        x -= width / 2;
        y -= height / 2;
    }

    ctx.drawImage(image, x, y, width, height);
}

function getCanvasContext(context) {
    return context.canvas.getContext("2d");
}