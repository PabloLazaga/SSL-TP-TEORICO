IMAGE=dotnet-dev

build:
	docker build -t $(IMAGE) .

run-csharp:
	docker run --rm \
		-v "$(shell pwd)":/workspace \
		-w /workspace \
		$(IMAGE) \
		dotnet run -c Release --project CSharp

run-fsharp:
	docker run --rm \
		-v "$(shell pwd)":/workspace \
		-w /workspace \
		$(IMAGE) \
		dotnet run -c Release --project FSharp