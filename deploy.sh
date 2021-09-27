#!/bin/bash
set -ev

cd src
pwd
ls -la

echo NUGET_API_KEY ... contents hidden
echo NUGET_SOURCE == ${NUGET_SOURCE} 
echo TRAVIS_PULL_REQUEST == ${TRAVIS_PULL_REQUEST}
echo BUILD_CONFIG == ${BUILD_CONFIG}

echo BUILD_DIR == ${BUILD_DIR}

dotnet build -c $BUILD_CONFIG CCBQuickCategorizerV2

if [ "${TRAVIS_PULL_REQUEST}" = "false" ] && [ "${TRAVIS_BRANCH}" = "master" ]; then
		dotnet nuget push ./BOG.DropZone.Common/bin/$BUILD_CONFIG/BOG.DropZone.Common.*.nupkg --api-key ${NUGET_API_KEY} --source ${NUGET_SOURCE} --skip-duplicate
		dotnet nuget push ./BOG.DropZone.Client/bin/$BUILD_CONFIG/BOG.DropZone.Client.*.nupkg --api-key ${NUGET_API_KEY} --source ${NUGET_SOURCE} --skip-duplicate
fi
