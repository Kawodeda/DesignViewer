export function getHtmlImage(content) {
    const blob = new Blob([content.buffer], { type: 'image/png' });
    const imageUrl = URL.createObjectURL(blob);

    return getLoadedImage(imageUrl);
}

export function getLoadedImage(url) {
    return new Promise((resolve, reject) => {
        const image = new Image();
        image.onload = () => {
            resolve(image);
        };
        image.src = url;
    });
}