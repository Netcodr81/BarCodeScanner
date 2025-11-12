window.barcodeScanner = {
    isScanning: false,
    dotNetReference: null,

    // Initialize the barcode scanner
    initialize: function (dotNetRef) {
        this.dotNetReference = dotNetRef;
    },

    // Start the barcode scanner
    start: function (elementId) {
        if (this.isScanning) {
            return false;
        }

        const self = this;

        Quagga.init({
            inputStream: {
                name: "Live",
                type: "LiveStream",
                target: document.querySelector('#' + elementId),
                constraints: {
                    width: 640,
                    height: 480,
                    facingMode: "environment" // use back camera if available
                }
            },
            locator: {
                patchSize: "medium",
                halfSample: true
            },
            numOfWorkers: 2,
            decoder: {
                readers: [
                    "code_128_reader",
                    "ean_reader",
                    "upc_reader"
                ]
            },
            locate: true
        }, function (err) {
            if (err) {
                console.log(err);
                if (self.dotNetReference) {
                    self.dotNetReference.invokeMethodAsync('OnError', 'Failed to initialize camera: ' + err.message);
                }
                return;
            }

            console.log("Initialization finished. Ready to start");
            Quagga.start();
            self.isScanning = true;

            if (self.dotNetReference) {
                self.dotNetReference.invokeMethodAsync('OnScannerStarted');
            }
        });

        // Listen for successful barcode detection
        Quagga.onDetected(function (result) {
            const code = result.codeResult.code;
            const format = result.codeResult.format;

            console.log("Barcode detected:", code, "Format:", format);

            if (self.dotNetReference) {
                self.dotNetReference.invokeMethodAsync('OnBarcodeDetected', code, format);
            }
        });

        // Listen for processing events (optional - for debugging)
        Quagga.onProcessed(function (result) {
            var drawingCtx = Quagga.canvas.ctx.overlay;
            var drawingCanvas = Quagga.canvas.dom.overlay;

            if (result) {
                if (result.boxes) {
                    drawingCtx.clearRect(0, 0, parseInt(drawingCanvas.getAttribute("width")), parseInt(drawingCanvas.getAttribute("height")));
                    result.boxes.filter(function (box) {
                        return box !== result.box;
                    }).forEach(function (box) {
                        Quagga.ImageDebug.drawPath(box, {x: 0, y: 1}, drawingCtx, {color: "green", lineWidth: 2});
                    });
                }

                if (result.box) {
                    Quagga.ImageDebug.drawPath(result.box, {x: 0, y: 1}, drawingCtx, {color: "#00F", lineWidth: 2});
                }

                if (result.codeResult && result.codeResult.code) {
                    Quagga.ImageDebug.drawPath(result.line, {x: 'x', y: 'y'}, drawingCtx, {color: 'red', lineWidth: 3});
                }
            }
        });

        return true;
    },

    // Stop the barcode scanner
    stop: function () {
        if (this.isScanning) {
            Quagga.stop();
            this.isScanning = false;

            if (this.dotNetReference) {
                this.dotNetReference.invokeMethodAsync('OnScannerStopped');
            }
        }
    },

    // Check if scanner is currently running
    getIsScanning: function () {
        return this.isScanning;
    }
};