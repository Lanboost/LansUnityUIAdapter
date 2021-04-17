#!/bin/bash
die () {
    echo >&2 "$@"
    exit 1
}

[ "$#" -eq 2 ] || die "2 argument required, $# provided"

version="v$1"
zip_name="release_any_cpu_$version.zip"
msbuild.exe "Example-MonoGame/Example-MonoGame/Example-MonoGame.sln" //p:Configuration=Release
pushd "Example-MonoGame/Example-MonoGame/bin/DesktopGL/AnyCPU/" ; zip -r "../../../../../$zip_name"  "Release" ; popd
./git-release.sh $version "$2"
./upload-github-release-asset.sh $version "./$zip_name"