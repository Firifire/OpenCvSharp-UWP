set(the_description "ArUco Marker Detection")

if(DEFINED WINRT AND NOT DEFINED ENABLE_WINRT_MODE_NATIVE)
  set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /ZW")
endif()

ocv_define_module(aruco opencv_core opencv_imgproc opencv_calib3d WRAP python java)
