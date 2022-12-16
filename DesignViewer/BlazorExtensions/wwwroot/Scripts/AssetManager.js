export async function getImageUrl(imageBytes) {
    const blob = new Blob([imageBytes.buffer]);

    return URL.createObjectURL(blob);
}

export function getElementWidth(element) {
    return element.clientWidth;
}