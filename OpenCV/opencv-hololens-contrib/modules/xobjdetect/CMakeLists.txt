set(the_description "Object detection algorithms")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(xobjdetect opencv_core opencv_imgproc opencv_objdetect opencv_imgcodecs WRAP python)
if (BUILD_opencv_apps AND NOT APPLE_FRAMEWORK)
    add_subdirectory(${CMAKE_CURRENT_SOURCE_DIR}/tools ${CMAKE_CURRENT_BINARY_DIR}/tools)
endif()
