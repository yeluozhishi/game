// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Message.proto

public interface MessageOrBuilder extends
    // @@protoc_insertion_point(interface_extends:Message)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>string topic = 1;</code>
   * @return The topic.
   */
  java.lang.String getTopic();
  /**
   * <code>string topic = 1;</code>
   * @return The bytes for topic.
   */
  com.google.protobuf.ByteString
      getTopicBytes();

  /**
   * <code>int32 command = 2;</code>
   * @return The command.
   */
  int getCommand();

  /**
   * <code>fixed64 playerId = 3;</code>
   * @return The playerId.
   */
  long getPlayerId();
}
