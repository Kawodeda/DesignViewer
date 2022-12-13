export function getHtmlImage(content) {
    const blob = new Blob([content.buffer], { type: 'image/png' });
    const image = new Image();
    image.src = URL.createObjectURL(blob);

    return image;
}