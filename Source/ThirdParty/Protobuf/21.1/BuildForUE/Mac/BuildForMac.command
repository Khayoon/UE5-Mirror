#!/bin/zsh -e
# Copyright Epic Games, Inc. All Rights Reserved.

LIB_ROOT=${0:a:h:h:h}
THIRDPARTY_ROOT=${LIB_ROOT:h:h}
ENGINE_ROOT=${THIRDPARTY_ROOT:h:h}
CMAKE_ADDITIONAL_ARGUMENTS="-DBUILD_SHARED_LIBS=OFF -Dprotobuf_BUILD_TESTS=OFFF -DCMAKE_FIND_USE_SYSTEM_ENVIRONMENT_PATH=OFF -DCMAKE_OSX_DEPLOYMENT_TARGET=10.14"
CMAKE_ZLIB_ARGUMENTS="-DZLIB_LIBRARY=${THIRDPARTY_ROOT}/zlib/1.2.12/lib/Mac/Release/libz.a -DZLIB_INCLUDE_DIR=%THIRDPARTY_ROOT%/zlib/1.2.12/include"
${THIRDPARTY_ROOT}/CMake/PlatformScripts/Mac/BuildLibForMac.command ${LIB_ROOT:h:t} ${LIB_ROOT:t} --config=Release --cmake-args="${CMAKE_ADDITIONAL_ARGUMENTS}"
