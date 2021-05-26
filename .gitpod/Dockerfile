FROM gitpod/workspace-dotnet:latest

# environment vars for build
ARG DOTNET_CLI_TELEMETRY_OPTOUT=1
ARG PATH=~/.dotnet/tools/:$PATH

# install cake
USER root
RUN dotnet tool install cake.tool -g --version=0.38.5

# environment vars for image
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV PATH=~/.dotnet/tools/:$PATH
