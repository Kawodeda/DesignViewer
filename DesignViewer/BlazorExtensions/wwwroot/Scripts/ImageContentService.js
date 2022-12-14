export function getHtmlImage(content) {
    const blob = new Blob([content.buffer], { type: 'image/png' });
    const imageUrl = URL.createObjectURL(blob);

    return loadImage(imageUrl);
}

export function loadImage(url) {
    return new Promise((resolve, reject) => {
        const image = new Image();
        image.onload = () => {
            resolve(image);
        };
        image.src = url;
    });
}

export function getImageWidth(image) {
    return image.naturalWidth;
}

export function getImageHeight(image) {
    return image.naturalHeight;
}